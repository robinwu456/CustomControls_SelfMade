using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButton {
    class ColorSwitch {
        private CustomButton customButton;
        private enum ButtonStatus { Normal, Hover, Press, Disabled }
        private Dictionary<ButtonStatus, Color[]> cmdColor = new Dictionary<ButtonStatus, Color[]>();

        public ColorSwitch(CustomButton customButton) {
            this.customButton = customButton;

            cmdColor = new Dictionary<ButtonStatus, Color[]>() {
                { ButtonStatus.Normal,   new Color[]{ customButton._BackColor_Normal, customButton._BackColor2_Normal } },  // 漸層左邊, 右邊
                { ButtonStatus.Hover,    new Color[]{ customButton.BackColor_Hover, customButton.BackColor2_Hover } },
                { ButtonStatus.Press,    new Color[]{ customButton.BackColor_Press, customButton.BackColor2_Press } },
                { ButtonStatus.Disabled, new Color[]{ customButton.BackColor_Disabled, customButton.BackColor2_Disabled } },
            };

            customButton.lbBtnText.MouseEnter += Cmd_MouseEnter;
            customButton.lbBtnText.MouseLeave += Cmd_MouseLeave;
            customButton.lbBtnText.MouseDown += Cmd_MouseDown;
            customButton.lbBtnText.MouseUp += Cmd_MouseUp;
        }

        private void Cmd_MouseUp(object sender, MouseEventArgs e) {
            customButton.customPanelBtnBg.BackColor = cmdColor[ButtonStatus.Hover][0];
            customButton.customPanelBtnBg.BackColor2 = cmdColor[ButtonStatus.Hover][1];
            customButton.customPanelBtnBg.Invalidate();
        }

        private void Cmd_MouseDown(object sender, MouseEventArgs e) {
            customButton.customPanelBtnBg.BackColor = cmdColor[ButtonStatus.Press][0];
            customButton.customPanelBtnBg.BackColor2 = cmdColor[ButtonStatus.Press][1];
            customButton.customPanelBtnBg.Invalidate();
        }

        private void Cmd_MouseLeave(object sender, EventArgs e) {
            if (customButton.ButtonEnabled) {
                customButton.customPanelBtnBg.BackColor = cmdColor[ButtonStatus.Normal][0];
                customButton.customPanelBtnBg.BackColor2 = cmdColor[ButtonStatus.Normal][1];
                customButton.customPanelBtnBg.Invalidate();
            }
        }

        private void Cmd_MouseEnter(object sender, EventArgs e) {
            customButton.customPanelBtnBg.BackColor = cmdColor[ButtonStatus.Hover][0];
            customButton.customPanelBtnBg.BackColor2 = cmdColor[ButtonStatus.Hover][1];
            customButton.customPanelBtnBg.Invalidate();
        }
    }
}
