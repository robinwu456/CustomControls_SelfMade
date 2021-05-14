namespace TestControls {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            CustomPicButton.ImgInfo imgInfo4 = new CustomPicButton.ImgInfo();
            CustomPicButton.ImgInfo imgInfo5 = new CustomPicButton.ImgInfo();
            CustomPicButton.ImgInfo imgInfo6 = new CustomPicButton.ImgInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customToggle1 = new CustomToggle.CustomToggle();
            this.customPicButton1 = new CustomPicButton.CustomPicButton();
            this.customButton1 = new CustomButton.CustomButton();
            this.SuspendLayout();
            // 
            // customToggle1
            // 
            this.customToggle1.BackImg_ToggleOff_Disabled = global::TestControls.Properties.Resources.toggleOff_disable;
            this.customToggle1.BackImg_ToggleOff_Hover = global::TestControls.Properties.Resources.toggleOff_hover;
            this.customToggle1.BackImg_ToggleOff_Normal = global::TestControls.Properties.Resources.toggleOff;
            this.customToggle1.BackImg_ToggleOn_Disabled = global::TestControls.Properties.Resources.toggleOn_disable;
            this.customToggle1.BackImg_ToggleOn_Hover = global::TestControls.Properties.Resources.toggleOn_hover;
            this.customToggle1.BackImg_ToggleOn_Normal = global::TestControls.Properties.Resources.toggleOn;
            this.customToggle1.Checked = false;
            this.customToggle1.Location = new System.Drawing.Point(435, 312);
            this.customToggle1.Name = "customToggle1";
            this.customToggle1.Size = new System.Drawing.Size(34, 20);
            this.customToggle1.TabIndex = 2;
            // 
            // customPicButton1
            // 
            imgInfo4.BackImg_Disabled = null;
            imgInfo4.BackImg_Hover = null;
            imgInfo4.BackImg_Normal = null;
            imgInfo4.BackImg_Press = null;
            this.customPicButton1.BackImg_ENG = imgInfo4;
            imgInfo5.BackImg_Disabled = null;
            imgInfo5.BackImg_Hover = null;
            imgInfo5.BackImg_Normal = null;
            imgInfo5.BackImg_Press = null;
            this.customPicButton1.BackImg_JP = imgInfo5;
            imgInfo6.BackImg_Disabled = ((System.Drawing.Image)(resources.GetObject("imgInfo6.BackImg_Disabled")));
            imgInfo6.BackImg_Hover = ((System.Drawing.Image)(resources.GetObject("imgInfo6.BackImg_Hover")));
            imgInfo6.BackImg_Normal = global::TestControls.Properties.Resources.home_新增連線3;
            imgInfo6.BackImg_Press = ((System.Drawing.Image)(resources.GetObject("imgInfo6.BackImg_Press")));
            this.customPicButton1.BackImg_TW = imgInfo6;
            this.customPicButton1.ButtonEnabled = true;
            this.customPicButton1.Culture = CustomPicButton.CustomPicButton.Language.Chinese;
            this.customPicButton1.Location = new System.Drawing.Point(194, 234);
            this.customPicButton1.Name = "customPicButton1";
            this.customPicButton1.PicPadding = new System.Windows.Forms.Padding(0);
            this.customPicButton1.Size = new System.Drawing.Size(60, 30);
            this.customPicButton1.TabIndex = 1;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackColor_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.customButton1.BackColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.customButton1.BackColor_Press = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.customButton1.BackColor2_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.customButton1.BackColor2_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(61)))));
            this.customButton1.BackColor2_Press = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.customButton1.ButtonEnabled = true;
            this.customButton1.ButtonText = "butto";
            this.customButton1.Curvature = 4;
            this.customButton1.GradientMode = CustomButton.LinearGradientMode.Horizontal;
            this.customButton1.Location = new System.Drawing.Point(313, 133);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(60, 30);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customToggle1);
            this.Controls.Add(this.customPicButton1);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.CustomButton customButton1;
        private CustomPicButton.CustomPicButton customPicButton1;
        private CustomToggle.CustomToggle customToggle1;
    }
}

