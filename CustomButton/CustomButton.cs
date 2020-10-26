using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomButton {
    [DefaultEvent("Click")]
    public partial class CustomButton : UserControl {
        public Color BackColor_Normal {
            get {
                return customPanelBtnBg.BackColor;
            }
            set {
                customPanelBtnBg.BackColor = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public Color BackColor2_Normal {
            get {
                return customPanelBtnBg.BackColor2;
            }
            set {
                customPanelBtnBg.BackColor2 = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public Color BackColor_Hover { get; set; } = Color.FromArgb(185, 185, 185);
        public Color BackColor2_Hover { get; set; } = Color.FromArgb(121, 121, 121);

        public Color BackColor_Press { get; set; } = Color.FromArgb(64, 60, 60);
        public Color BackColor2_Press { get; set; } = Color.FromArgb(64, 60, 60);

        [DefaultValueAttribute(typeof(LinearGradientMode), "None"), CategoryAttribute("Appearance"), DescriptionAttribute("The gradient direction used to paint the control.")]
        public LinearGradientMode GradientMode {
            get {
                return customPanelBtnBg.GradientMode;
            }
            set {
                customPanelBtnBg.GradientMode = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        [DefaultValueAttribute(typeof(BorderStyle), "None"), CategoryAttribute("Appearance"), DescriptionAttribute("The border style used to paint the control.")]
        public new BorderStyle BorderStyle {
            get {
                return customPanelBtnBg.BorderStyle;
            }
            set {
                customPanelBtnBg.BorderStyle = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        [DefaultValueAttribute(typeof(Color), "WindowFrame"), CategoryAttribute("Appearance"), DescriptionAttribute("The border color used to paint the control.")]
        public Color BorderColor {
            get {
                return customPanelBtnBg.BorderColor;
            }
            set {
                customPanelBtnBg.BorderColor = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        [DefaultValueAttribute(typeof(int), "1"), CategoryAttribute("Appearance"), DescriptionAttribute("The width of the border used to paint the control.")]
        public int BorderWidth {
            get {
                return customPanelBtnBg.BorderWidth;
            }
            set {
                customPanelBtnBg.BorderWidth = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        [DefaultValueAttribute(typeof(int), "0"), CategoryAttribute("Appearance"), DescriptionAttribute("The radius of the curve used to paint the corners of the control.")]
        public int Curvature {
            get {
                return customPanelBtnBg.Curvature;
            }
            set {
                customPanelBtnBg.Curvature = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        [DefaultValueAttribute(typeof(CornerCurveMode), "All"), CategoryAttribute("Appearance"), DescriptionAttribute("The style of the curves to be drawn on the control.")]
        public CornerCurveMode CurveMode {
            get {
                return customPanelBtnBg.CurveMode;
            }
            set {
                customPanelBtnBg.CurveMode = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public new Font Font {
            get {
                return lbBtnText.Font;
            }
            set {
                lbBtnText.Font = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public new Color ForeColor {
            get {
                return lbBtnText.ForeColor;
            }
            set {
                lbBtnText.ForeColor = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public string ButtonText {
            get {
                return lbBtnText.Text;
            }
            set {
                lbBtnText.Text = value;
                if (this.DesignMode == true) {
                    this.Invalidate();
                }
            }
        }

        public CustomButton() {
            InitializeComponent();

            ColorSwitch colorSwitch = new ColorSwitch(this);

            lbBtnText.MouseUp += LbBtnText_MouseUp;
            lbBtnText.MouseDown += LbBtnText_MouseDown;
            lbBtnText.Click += LbBtnText_Click;
        }

        private void LbBtnText_Click(object sender, EventArgs e) {
            OnClick(e);
        }

        private void LbBtnText_MouseUp(object sender, MouseEventArgs e) {
            OnMouseUp(e);
        }

        private void LbBtnText_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(e);
        }
    }
}
