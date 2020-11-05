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
        private Dictionary<CustomPicButton.Language, Dictionary<ButtonStatus, Image>> cmdImg = new Dictionary<CustomPicButton.Language, Dictionary<ButtonStatus, Image>>();

        public ImgSwitch(CustomPicButton customPicButton) {
            this.customPicButton = customPicButton;

            cmdImg = new Dictionary<CustomPicButton.Language, Dictionary<ButtonStatus, Image>>() {
                { CustomPicButton.Language.Chinese, new Dictionary<ButtonStatus, Image>(){
                    { ButtonStatus.Normal,   customPicButton.BackImg_TW != null ? customPicButton.BackImg_TW.BackImg_Normal : null },
                    { ButtonStatus.Hover,    customPicButton.BackImg_TW != null ? customPicButton.BackImg_TW.BackImg_Hover : null },
                    { ButtonStatus.Press,    customPicButton.BackImg_TW != null ? customPicButton.BackImg_TW.BackImg_Press : null },
                    { ButtonStatus.Disabled, customPicButton.BackImg_TW != null ? customPicButton.BackImg_TW.BackImg_Disabled : null },
                } },
                { CustomPicButton.Language.English, new Dictionary<ButtonStatus, Image>(){
                    { ButtonStatus.Normal,   customPicButton.BackImg_ENG != null ? customPicButton.BackImg_ENG.BackImg_Normal : null },
                    { ButtonStatus.Hover,    customPicButton.BackImg_ENG != null ? customPicButton.BackImg_ENG.BackImg_Hover : null },
                    { ButtonStatus.Press,    customPicButton.BackImg_ENG != null ? customPicButton.BackImg_ENG.BackImg_Press : null },
                    { ButtonStatus.Disabled, customPicButton.BackImg_ENG != null ? customPicButton.BackImg_ENG.BackImg_Disabled : null },
                } },
                { CustomPicButton.Language.Japan, new Dictionary<ButtonStatus, Image>(){
                    { ButtonStatus.Normal,   customPicButton.BackImg_JP != null ? customPicButton.BackImg_JP.BackImg_Normal : null },
                    { ButtonStatus.Hover,    customPicButton.BackImg_JP != null ? customPicButton.BackImg_JP.BackImg_Hover : null },
                    { ButtonStatus.Press,    customPicButton.BackImg_JP != null ? customPicButton.BackImg_JP.BackImg_Press : null },
                    { ButtonStatus.Disabled, customPicButton.BackImg_JP != null ? customPicButton.BackImg_JP.BackImg_Disabled : null },
                } },
            };

            customPicButton.picBtn.MouseEnter += Cmd_MouseEnter;
            customPicButton.picBtn.MouseLeave += Cmd_MouseLeave;
            customPicButton.picBtn.MouseDown += Cmd_MouseDown;
            customPicButton.picBtn.MouseUp += Cmd_MouseUp;
            customPicButton.EnabledChanged += CustomPicButton_EnabledChanged;
        }

        private void CustomPicButton_EnabledChanged(object sender, EventArgs e) {
            customPicButton.picBtn.Image = customPicButton.Enabled ?
                cmdImg[customPicButton.Culture][ButtonStatus.Normal] : cmdImg[customPicButton.Culture][ButtonStatus.Disabled];
        }

        private void Cmd_MouseUp(object sender, MouseEventArgs e) {
            if (!customPicButton.ButtonEnabled)
                return;
            PictureBox cmd = sender as PictureBox;
            if (cmd.ClientRectangle.Contains(cmd.PointToClient(Control.MousePosition)))
                customPicButton.picBtn.Image = cmdImg[customPicButton.Culture][ButtonStatus.Hover];
            else
                customPicButton.picBtn.Image = cmdImg[customPicButton.Culture][ButtonStatus.Normal];
        }

        private void Cmd_MouseDown(object sender, MouseEventArgs e) {
            if (!customPicButton.ButtonEnabled)
                return;
            customPicButton.picBtn.Image = cmdImg[customPicButton.Culture][ButtonStatus.Press];
        }

        private void Cmd_MouseLeave(object sender, EventArgs e) {
            if (!customPicButton.ButtonEnabled)
                return;
            customPicButton.picBtn.Image = cmdImg[customPicButton.Culture][ButtonStatus.Normal];
        }

        private void Cmd_MouseEnter(object sender, EventArgs e) {
            if (!customPicButton.ButtonEnabled)
                return;
            customPicButton.picBtn.Image = cmdImg[customPicButton.Culture][ButtonStatus.Hover];
        }
    }
}
