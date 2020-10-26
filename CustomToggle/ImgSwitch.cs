using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CustomToggle {
    public class ImgSwitch {
        private enum ImgKind {
            ToggleOn,
            ToggleOff,
            ToggleOnHover,
            ToggleOffHover,
            ToggleOnDisabled,
            ToggleOffDisabled,
        }
        private Dictionary<PictureBox, Dictionary<ImgKind, Image>> mapPic;
        private CustomToggle toggle;

        public ImgSwitch(CustomToggle customToggle) {
            this.toggle = customToggle;

            mapPic = new Dictionary<PictureBox, Dictionary<ImgKind, Image>>() {
                //{ customToggle.picToggle, new Dictionary<ImgKind, Image>(){
                //    { ImgKind.ToggleOn, Properties.Resources.toggleOn },
                //    { ImgKind.ToggleOff, Properties.Resources.toggleOff },
                //    { ImgKind.ToggleOnHover, Properties.Resources.toggleOn_hover },
                //    { ImgKind.ToggleOffHover, Properties.Resources.toggleOff_hover },
                //    { ImgKind.ToggleOnDisabled, Properties.Resources.toggleOn_disable },
                //    { ImgKind.ToggleOffDisabled, Properties.Resources.toggleOff_disable }
                //} },
                { customToggle.picToggle, new Dictionary<ImgKind, Image>(){
                    { ImgKind.ToggleOn, customToggle.BackImg_ToggleOn_Normal },
                    { ImgKind.ToggleOff, customToggle.BackImg_ToggleOff_Normal },
                    { ImgKind.ToggleOnHover, customToggle.BackImg_ToggleOn_Hover },
                    { ImgKind.ToggleOffHover, customToggle.BackImg_ToggleOff_Hover },
                    { ImgKind.ToggleOnDisabled, customToggle.BackImg_ToggleOn_Disabled },
                    { ImgKind.ToggleOffDisabled, customToggle.BackImg_ToggleOff_Disabled }
                } },
            };

            customToggle.picToggle.MouseEnter += MouseEnter;
            customToggle.picToggle.MouseLeave += MouseLeave;
            customToggle.picToggle.MouseUp += MouseUp;
            customToggle.picToggle.MouseDown += MouseDown;
        }

        public void UpdateCurStatus(object sender, EventArgs e) {
            MouseLeave(sender, e);
        }

        private void MouseLeave(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            if (toggle.Enabled) {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOn];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOff];
            } else {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOffDisabled];
            }
        }

        private void MouseEnter(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            if (toggle.Enabled) {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnHover];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOffHover];
            } else {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOffDisabled];
            }
        }

        private void MouseUp(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            if (toggle.Enabled) {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnHover];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOffHover];
            } else {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
            }
        }

        private void MouseDown(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            if (toggle.Enabled) {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOn];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOff];
            } else {
                if (toggle.Checked)
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
                else
                    pic.Image = mapPic[pic][ImgKind.ToggleOnDisabled];
            }
        }
    }
}
