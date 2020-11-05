using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace CustomPicButton {
    [TypeConverter(typeof(ImgInfoTypeConverter))]
    public class ImgInfo {
        //public Image BackImg_Normal { get; set; }
        //public Image BackImg_Hover { get; set; }
        //public Image BackImg_Press { get; set; }
        //public Image BackImg_Disabled { get; set; }

        private Image _BackImg_Normal;
        private Image _BackImg_Hover;
        private Image _BackImg_Press;
        private Image _BackImg_Disabled;

        public Image BackImg_Normal {
            get { return _BackImg_Normal; }
            set { _BackImg_Normal = value; }
        }
        public Image BackImg_Hover {
            get { return _BackImg_Hover; }
            set { _BackImg_Hover = value; }
        }
        public Image BackImg_Press {
            get { return _BackImg_Press; }
            set { _BackImg_Press = value; }
        }
        public Image BackImg_Disabled {
            get { return _BackImg_Disabled; }
            set { _BackImg_Disabled = value; }
        }
    }
}
