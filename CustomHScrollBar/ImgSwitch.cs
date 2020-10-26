using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CustomHScrollBar {
    public class ImgSwitch {
        private enum ImgKind { Normal, Hover }
        private Dictionary<PictureBox, Dictionary<ImgKind, Image>> mapPic;

        public ImgSwitch(CustomHScrollBar customHScrollBar) {
            mapPic = new Dictionary<PictureBox, Dictionary<ImgKind, Image>>() {
                { customHScrollBar.hScrollBarThumb, new Dictionary<ImgKind, Image>(){ { ImgKind.Normal, Properties.Resources.scrollBarThumb }, { ImgKind.Hover, Properties.Resources.scrollBarThumb_hover } } },
                { customHScrollBar.hScrollBarArrowLeft, new Dictionary<ImgKind, Image>(){ { ImgKind.Normal, Properties.Resources.scrollBarArrowLeft }, { ImgKind.Hover, Properties.Resources.scrollBarArrowLeft_hover } } },
                { customHScrollBar.hScrollBarArrowRight, new Dictionary<ImgKind, Image>(){ { ImgKind.Normal, Properties.Resources.scrollBarArrowRight }, { ImgKind.Hover, Properties.Resources.scrollBarArrowRight_hover } } },
            };

            customHScrollBar.hScrollBarThumb.MouseEnter += MouseEnter;
            customHScrollBar.hScrollBarArrowLeft.MouseEnter += MouseEnter;
            customHScrollBar.hScrollBarArrowRight.MouseEnter += MouseEnter;
            customHScrollBar.hScrollBarThumb.MouseLeave += MouseLeave;
            customHScrollBar.hScrollBarArrowLeft.MouseLeave += MouseLeave;
            customHScrollBar.hScrollBarArrowRight.MouseLeave += MouseLeave;
        }

        private void MouseEnter(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            pic.Image = mapPic[pic][ImgKind.Hover];
        }

        private void MouseLeave(object sender, EventArgs e) {
            PictureBox pic = sender as PictureBox;
            pic.Image = mapPic[pic][ImgKind.Normal];
        }
    }
}
