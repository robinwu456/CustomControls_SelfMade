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
        private ImgInfo _BackImg_TW;
        public ImgInfo BackImg_TW {
            get {
                return _BackImg_TW;
            }
            set {
                if (value == null) {
                    ImgInfo imgInfo = new ImgInfo();
                    _BackImg_TW = imgInfo;
                } else {
                    _BackImg_TW = value;
                    if (_BackImg_TW.BackImg_Normal != null) {
                        this.Size = _BackImg_TW.BackImg_Normal.Size;
                        picBtn.Image = _BackImg_TW.BackImg_Normal;
                    }
                }
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        private ImgInfo _BackImg_ENG;
        public ImgInfo BackImg_ENG {
            get {
                return _BackImg_ENG;
            }
            set {
                if (value == null) {
                    ImgInfo imgInfo = new ImgInfo();
                    _BackImg_ENG = imgInfo;
                } else {
                    _BackImg_ENG = value;
                    if (_BackImg_ENG.BackImg_Normal != null) {
                        this.Size = _BackImg_ENG.BackImg_Normal.Size;
                        picBtn.Image = _BackImg_ENG.BackImg_Normal;
                    }
                }
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        private ImgInfo _BackImg_JP;
        public ImgInfo BackImg_JP {
            get {
                return _BackImg_JP;
            }
            set {
                if (value == null) {
                    ImgInfo imgInfo = new ImgInfo();
                    _BackImg_JP = imgInfo;
                } else {
                    _BackImg_JP = value;
                    if (_BackImg_JP.BackImg_Normal != null) {
                        this.Size = _BackImg_JP.BackImg_Normal.Size;
                        picBtn.Image = _BackImg_JP.BackImg_Normal;
                    }
                }
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        public enum Language {
            Chinese,
            English,
            Japan
        }
        private Language _Culture = Language.Chinese;
        public Language Culture {
            get {
                return _Culture;
            }
            set {
                _Culture = value;
                switch (_Culture) {
                    case Language.Chinese:
                        if (BackImg_TW != null && BackImg_TW.BackImg_Normal != null)
                            picBtn.Image = BackImg_TW.BackImg_Normal;
                        break;
                    case Language.English:
                        if (BackImg_ENG != null && BackImg_ENG.BackImg_Normal != null)
                            picBtn.Image = BackImg_ENG.BackImg_Normal;
                        break;
                    case Language.Japan:
                        if (BackImg_JP != null && BackImg_JP.BackImg_Normal != null)
                            picBtn.Image = BackImg_JP.BackImg_Normal;
                        break;
                }
                this.Size = new Size(
                    picBtn.Image.Size.Width + picBtn.Padding.Left + picBtn.Padding.Right,
                    picBtn.Image.Size.Height + picBtn.Padding.Top + picBtn.Padding.Bottom
                );
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        public Padding PicPadding {
            get {
                return picBtn.Padding;
            }
            set {
                picBtn.Padding = value;
                if (picBtn.Image != null)
                    this.Size = new Size(
                        picBtn.Image.Size.Width + value.Left + value.Right,
                        picBtn.Image.Size.Height + value.Top + value.Bottom
                    );
                if (this.DesignMode == true)
                    this.Invalidate();
            }
        }

        private bool _ButtonEnabled = true;
        public bool ButtonEnabled {
            get {
                return _ButtonEnabled;
            }
            set {
                _ButtonEnabled = value;
                if (_ButtonEnabled) {
                    switch (_Culture) {
                        case Language.Chinese:
                            if (BackImg_TW != null && BackImg_TW.BackImg_Normal != null)
                                picBtn.Image = BackImg_TW.BackImg_Normal;
                            break;
                        case Language.English:
                            if (BackImg_ENG != null && BackImg_ENG.BackImg_Normal != null)
                                picBtn.Image = BackImg_ENG.BackImg_Normal;
                            break;
                        case Language.Japan:
                            if (BackImg_JP != null && BackImg_JP.BackImg_Normal != null)
                                picBtn.Image = BackImg_JP.BackImg_Normal;
                            break;
                    }                    
                } else {
                    switch (_Culture) {
                        case Language.Chinese:
                            if (BackImg_TW != null && BackImg_TW.BackImg_Disabled != null)
                                picBtn.Image = BackImg_TW.BackImg_Disabled;
                            break;
                        case Language.English:
                            if (BackImg_ENG != null && BackImg_ENG.BackImg_Disabled != null)
                                picBtn.Image = BackImg_ENG.BackImg_Disabled;
                            break;
                        case Language.Japan:
                            if (BackImg_JP != null && BackImg_JP.BackImg_Disabled != null)
                                picBtn.Image = BackImg_JP.BackImg_Disabled;
                            break;
                    }
                }
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
