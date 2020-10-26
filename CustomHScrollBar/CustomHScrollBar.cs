using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace CustomHScrollBar {
    public partial class CustomHScrollBar : UserControl {
        // 委派事件
        public delegate void ThumbMouseEventHandler(object sender, MouseEventArgs e);
        [Category("自定義"), Description("當控制項的值變更時發生")]
        public event EventHandler ValueChanged;
        [Category("自定義"), Description("使用者移動捲動方塊時發生")]
        public event ScrollEventHandler Scroll;
        [Category("自定義"), Description("當釋放捲動方塊按鍵後發生")]
        public event ThumbMouseEventHandler ThumbMouseUp;
        // 內件參數
        [Category("自定義"), Description("ScrollBar值")]
        public int Value { get; set; } = 1;
        [Category("自定義"), Description("最小值")]
        public int MinValue { get; set; } = 0;
        [Category("自定義"), Description("最大值")]
        public int MaxValue { get; set; } = 100;
        [Category("自定義"), Description("箭頭按一下值更動Range")]
        public int SmallChange { get; set; } = 10;
        [Category("自定義"), Description("綁定的NumericUpDown")]
        public NumericUpDown BindingNumericUpDown { get; set; }
        [Category("自定義"), Description("綁定的TextBox")]
        public TextBox BindingTextBox { get; set; }
        [Category("自定義"), Description("綁定的Form")]
        public Form FormMain { get; set; }

        private Panel scrollBar;
        private PictureBox thumb;
        private PictureBox arrowLeft;
        private PictureBox arrowRight;
        private int px, py;
        private bool isDragging = false;
        private Thread threadMoving;
        private Thread threadValueChanged;
        private Thread threadUpdateNumeric;
        private Thread threadUpdateTextBox;
        private int minPosOffset = 12;
        private int maxPosOffset = 35;
        private ScrollEventType curScrollType;
        private enum FocusOn { ScrollBar, Input }
        private FocusOn curFocusOn = FocusOn.ScrollBar;
        private string placeHolder = null;

        public CustomHScrollBar() {
            InitializeComponent();

            this.scrollBar = hScrollBar;
            this.thumb = hScrollBarThumb;
            this.arrowLeft = hScrollBarArrowLeft;
            this.arrowRight = hScrollBarArrowRight;
            ImgSwitch imgSwitch = new ImgSwitch(this);
        }

        private void CustomHScrollBar_Load(object sender, EventArgs e) {
            Initialize();
        }

        public void Initialize() {
            // 初始化位置
            thumb.Location = new Point(
                (int)(((float)Value / (float)MaxValue) * (scrollBar.Size.Width - maxPosOffset) + minPosOffset),
                thumb.Location.Y
            );

            // 改值偵測
            threadValueChanged = new Thread(CheckValueChanged);
            threadValueChanged.Start();

            // numerice改值thread
            if (BindingNumericUpDown != null) {
                threadUpdateNumeric = new Thread(UpdateNumeric);
                threadUpdateNumeric.Start();
            }
            // textBox改值thread
            if (BindingTextBox != null) {
                threadUpdateTextBox = new Thread(UpdateTextBox);
                threadUpdateTextBox.Start();
            }

            InitEvents();
        }

        private void InitEvents() {
            thumb.MouseDown += Thumb_MouseDown;
            thumb.MouseUp += Thumb_MouseUp;
            thumb.MouseMove += Thumb_MouseMove;
            arrowLeft.MouseDown += ArrowLeft_MouseDown;
            arrowRight.MouseDown += ArrowRight_MouseDown;

            // numeric
            if (BindingNumericUpDown != null)
                BindingNumericUpDown.ValueChanged += BindingNumericUpDown_ValueChanged;
            // textbox
            if (BindingTextBox != null) {
                BindingTextBox.Enter += BindingTextBox_Enter;
                BindingTextBox.Leave += BindingTextBox_Leave;
                BindingTextBox.KeyDown += BindingTextBox_KeyDown;
            }
        }

        private void ArrowRight_MouseDown(object sender, MouseEventArgs e) {
            curFocusOn = FocusOn.ScrollBar;
            if (Value + SmallChange <= MaxValue)
                Value += SmallChange;
        }

        private void ArrowLeft_MouseDown(object sender, MouseEventArgs e) {
            curFocusOn = FocusOn.ScrollBar;
            if (Value - SmallChange >= 0)
                Value -= SmallChange;
        }

        private void BindingTextBox_Leave(object sender, EventArgs e) {
            //if (string.IsNullOrEmpty(bindingTextBox.Text))
            //    showPlaceHolder = true;
            //curFocusOn = FocusOn.ScrollBar;
        }

        private void BindingTextBox_Enter(object sender, EventArgs e) {
            curFocusOn = FocusOn.Input;

            //showPlaceHolder = false;
        }

        private void BindingTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                int a = 0;
                if (Int32.TryParse(BindingTextBox.Text, out a)) {
                    Value = a;
                }
            }
        }

        private void BindingNumericUpDown_ValueChanged(object sender, EventArgs e) {
            Value = (int)BindingNumericUpDown.Value;

            // 自定義邏輯(可修正)
            if (!isDragging)
                ThumbMouseUp?.Invoke(this, null);
        }

        private void Thumb_MouseMove(object sender, MouseEventArgs e) {
            if (isDragging)
                // 5為能顯示完整thumb的最大位置
                targetDistance = scrollBar.PointToClient(Cursor.Position).X - 5;
        }

        private void Thumb_MouseUp(object sender, MouseEventArgs e) {
            isDragging = false;
            curScrollType = ScrollEventType.EndScroll;
            curFocusOn = FocusOn.Input;

            threadMoving.Abort();

            // scrollBar mouse up event
            ThumbMouseUp?.Invoke(this, e);
        }

        private void Thumb_MouseDown(object sender, MouseEventArgs e) {
            px = e.X; // 記住滑鼠點下時相對於元件的 (x,y) 坐標。
            py = e.Y;
            isDragging = true;
            curScrollType = ScrollEventType.ThumbTrack;
            curFocusOn = FocusOn.ScrollBar;

            threadMoving = new Thread(MoveThumb);
            threadMoving.Start();
        }

        int targetDistance = 0;
        private void MoveThumb() {
            try {
                while (true) {
                    FormMain.Invoke(new Action(() => {
                        if (thumb.Location.X > targetDistance) {
                            int targetX = thumb.Location.X - 1;
                            if (targetX >= minPosOffset)
                                thumb.Location = new Point(targetX, thumb.Location.Y);
                        } else if (thumb.Location.X < targetDistance) {
                            int targetX = thumb.Location.X + 1;
                            if (targetX <= scrollBar.Size.Width - maxPosOffset + arrowRight.Size.Width)
                                thumb.Location = new Point(targetX, thumb.Location.Y);
                        }


                        //double curPercent = (float)(thumb.Location.X) / ((float)scrollBar.Size.Width - maxPosOffset);
                        //Value = (int)(curPercent * maxValue);

                        Value = (int)((float)(thumb.Location.X - minPosOffset) / (float)(scrollBar.Size.Width - maxPosOffset) * MaxValue);

                        // 滾動事件
                        if (Scroll != null) {
                            ScrollEventArgs e = new ScrollEventArgs(curScrollType, Value);
                            Scroll(this, e);
                        }
                    }));

                    Thread.Sleep(1);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                // 滾動事件
                if (Scroll != null) {
                    FormMain.Invoke(new Action(() => {
                        ScrollEventArgs e = new ScrollEventArgs(curScrollType, -1);
                        Scroll(this, e);
                    }));
                }
            }
        }

        private void CheckValueChanged() {
            try {
                int newValue = Value;
                int oldValue = Value;

                while (true) {
                    // 偵測主Form是否已關閉
                    if (FormMain.IsDisposed)
                        break;

                    newValue = Value;

                    if (oldValue != newValue) {
                        FormMain.Invoke(new Action(() => {
                            // 初始化位置
                            thumb.Location = new Point(
                                (int)(((float)Value / (float)MaxValue) * (scrollBar.Size.Width - maxPosOffset) + minPosOffset),
                                thumb.Location.Y
                            );

                            if (ValueChanged != null)
                                ValueChanged(this, null);
                        }));
                    }

                    oldValue = newValue;

                    Thread.Sleep(100);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UpdateNumeric() {
            try {
                while (true) {
                    // 偵測主Form是否已關閉
                    if (FormMain.IsDisposed)
                        break;

                    if (BindingNumericUpDown != null && curFocusOn == FocusOn.ScrollBar) {
                        FormMain.Invoke(new Action(() => {
                            BindingNumericUpDown.Value = Value;
                        }));
                    }

                    Thread.Sleep(1);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }        

        private void UpdateTextBox() {
            try {
                while (true) {
                    // 偵測主Form是否已關閉
                    if (FormMain.IsDisposed)
                        break;

                    if (BindingTextBox != null && curFocusOn == FocusOn.ScrollBar) {
                        FormMain.Invoke(new Action(() => {
                            BindingTextBox.Text = Value.ToString();

                            if (Int32.TryParse(BindingTextBox.Text, out int curTextBoxValue)) {
                                if (curTextBoxValue > MaxValue)
                                    BindingTextBox.Text = MaxValue.ToString();
                                if (curTextBoxValue < MinValue)
                                    BindingTextBox.Text = MinValue.ToString();
                            }
                        }));
                    }

                    Thread.Sleep(1);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
