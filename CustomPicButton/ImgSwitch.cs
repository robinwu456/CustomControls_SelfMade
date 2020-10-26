using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CustomPicButton {
    public class ImgSwitch {
        private CustomPicButton customPicButton;
        private enum ButtonStatus { Normal, Hover, Press, Disabled }
        private Dictionary<ButtonStatus, Image> cmdColor = new Dictionary<ButtonStatus, Image>();

        public ImgSwitch(CustomPicButton customPicButton) {
            this.customPicButton = customPicButton;

            cmdColor = new Dictionary<ButtonStatus, Image>() {
                { ButtonStatus.Normal,   customPicButton.BackImg_Normal },
                { ButtonStatus.Hover,    customPicButton.BackImg_Hover },
                { ButtonStatus.Press,    customPicButton.BackImg_Press },
                { ButtonStatus.Disabled, customPicButton.BackImg_Disabled },
            };

            customPicButton.picBtn.MouseEnter += Cmd_MouseEnter;
            customPicButton.picBtn.MouseLeave += Cmd_MouseLeave;
            customPicButton.picBtn.MouseDown += Cmd_MouseDown;
            customPicButton.picBtn.MouseUp += Cmd_MouseUp;
            customPicButton.EnabledChanged += CustomPicButton_EnabledChanged;
        }

        private void CustomPicButton_EnabledChanged(object sender, EventArgs e) {
            customPicButton.picBtn.Image = customPicButton.Enabled ?
                cmdColor[ButtonStatus.Normal] : cmdColor[ButtonStatus.Disabled];
        }

        private void Cmd_MouseUp(object sender, MouseEventArgs e) {
            PictureBox cmd = sender as PictureBox;
            if (cmd.ClientRectangle.Contains(cmd.PointToClient(Control.MousePosition)))
                customPicButton.picBtn.Image = cmdColor[ButtonStatus.Hover];
            else
                customPicButton.picBtn.Image = cmdColor[ButtonStatus.Normal];
        }

        private void Cmd_MouseDown(object sender, MouseEventArgs e) {
            customPicButton.picBtn.Image = cmdColor[ButtonStatus.Press];
        }

        private void Cmd_MouseLeave(object sender, EventArgs e) {
            customPicButton.picBtn.Image = cmdColor[ButtonStatus.Normal];
        }

        private void Cmd_MouseEnter(object sender, EventArgs e) {
            customPicButton.picBtn.Image = cmdColor[ButtonStatus.Hover];
        }
    }
}
