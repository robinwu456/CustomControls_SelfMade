using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomPicButton {
    public partial class CustomPicButton : UserControl {
        public Image BackImg_Normal {
            get {
                return picBtn.Image;
            }
            set {
                this.Size = value.Size;
                picBtn.Image = value;
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        public Image BackImg_Hover { get; set; }
        public Image BackImg_Press { get; set; }
        public Image BackImg_Disabled { get; set; }

        public Padding PicPadding {
            get {
                return picBtn.Padding;
            }
            set {
                picBtn.Padding = value;
                this.Size = new Size(
                    picBtn.Image.Size.Width + value.Left + value.Right,
                    picBtn.Image.Size.Height + value.Top + value.Bottom
                );
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        public CustomPicButton() {
            InitializeComponent();            

            picBtn.MouseUp += PicBtn_MouseUp;
            picBtn.MouseDown += PicBtn_MouseDown;
            picBtn.Click += PicBtn_Click;
        }        

        private void CustomPicButton_Load(object sender, EventArgs e) {
            ImgSwitch imgSwitch = new ImgSwitch(this);
        }

        private void PicBtn_Click(object sender, EventArgs e) {
            OnClick(e);
        }

        private void PicBtn_MouseUp(object sender, MouseEventArgs e) {
            OnMouseUp(e);
        }

        private void PicBtn_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(e);
        }        
    }
}
