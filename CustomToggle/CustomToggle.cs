using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomToggle {
    public partial class CustomToggle : UserControl {
        public Image BackImg_ToggleOn_Normal { get; set; }
        public Image BackImg_ToggleOff_Normal {
            get {
                return picToggle.Image;
            }
            set {
                this.Size = value.Size;
                picToggle.Image = value;
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }
        public Image BackImg_ToggleOn_Hover { get; set; }
        public Image BackImg_ToggleOff_Hover { get; set; }
        public Image BackImg_ToggleOn_Disabled { get; set; }
        public Image BackImg_ToggleOff_Disabled { get; set; }

        private bool _Checked = false;
        public bool Checked {
            get {
                return _Checked;
            } set {
                _Checked = value;
                if (BackImg_ToggleOn_Normal != null && BackImg_ToggleOff_Normal != null) {
                    picToggle.Image = _Checked ? BackImg_ToggleOn_Normal : BackImg_ToggleOff_Normal;
                    if (this.DesignMode == true)
                        this.Invalidate();
                }
            }
        }
        public event EventHandler CheckedChanged;

        private ImgSwitch imgSwitch;

        public CustomToggle() {
            InitializeComponent();

            picToggle.MouseUp += ToggleStatusSwitch;
            picToggle.EnabledChanged += PicToggle_EnabledChanged;            
        }

        private void CustomToggle_Load(object sender, EventArgs e) {
            imgSwitch = new ImgSwitch(this);
        }

        private void PicToggle_EnabledChanged(object sender, EventArgs e) {
            if (imgSwitch != null)
                imgSwitch.UpdateCurStatus(sender, e);
        }

        private void ToggleStatusSwitch(object sender, MouseEventArgs e) {
            Checked = !Checked;
            CheckedChanged?.Invoke(sender, e);
        }        
    }
}
