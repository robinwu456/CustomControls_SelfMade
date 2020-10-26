namespace CustomHScrollBar {
    partial class CustomHScrollBar {
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.hScrollBar = new System.Windows.Forms.Panel();
            this.hScrollBarArrowLeft = new System.Windows.Forms.PictureBox();
            this.hScrollBarArrowRight = new System.Windows.Forms.PictureBox();
            this.hScrollBarThumb = new System.Windows.Forms.PictureBox();
            this.hScrollBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar.BackgroundImage = global::CustomHScrollBar.Properties.Resources.scrollBar;
            this.hScrollBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hScrollBar.Controls.Add(this.hScrollBarArrowLeft);
            this.hScrollBar.Controls.Add(this.hScrollBarArrowRight);
            this.hScrollBar.Controls.Add(this.hScrollBarThumb);
            this.hScrollBar.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(145, 18);
            this.hScrollBar.TabIndex = 12;
            // 
            // hScrollBarArrowLeft
            // 
            this.hScrollBarArrowLeft.Image = global::CustomHScrollBar.Properties.Resources.scrollBarArrowLeft;
            this.hScrollBarArrowLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarArrowLeft.Location = new System.Drawing.Point(0, 3);
            this.hScrollBarArrowLeft.Name = "hScrollBarArrowLeft";
            this.hScrollBarArrowLeft.Size = new System.Drawing.Size(12, 12);
            this.hScrollBarArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hScrollBarArrowLeft.TabIndex = 83;
            this.hScrollBarArrowLeft.TabStop = false;
            // 
            // hScrollBarArrowRight
            // 
            this.hScrollBarArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarArrowRight.Image = global::CustomHScrollBar.Properties.Resources.scrollBarArrowRight;
            this.hScrollBarArrowRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarArrowRight.Location = new System.Drawing.Point(133, 3);
            this.hScrollBarArrowRight.Name = "hScrollBarArrowRight";
            this.hScrollBarArrowRight.Size = new System.Drawing.Size(12, 12);
            this.hScrollBarArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hScrollBarArrowRight.TabIndex = 82;
            this.hScrollBarArrowRight.TabStop = false;
            // 
            // hScrollBarThumb
            // 
            this.hScrollBarThumb.Image = global::CustomHScrollBar.Properties.Resources.scrollBarThumb;
            this.hScrollBarThumb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBarThumb.Location = new System.Drawing.Point(12, 2);
            this.hScrollBarThumb.Name = "hScrollBarThumb";
            this.hScrollBarThumb.Size = new System.Drawing.Size(14, 14);
            this.hScrollBarThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hScrollBarThumb.TabIndex = 79;
            this.hScrollBarThumb.TabStop = false;
            // 
            // CustomHScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hScrollBar);
            this.Name = "CustomHScrollBar";
            this.Size = new System.Drawing.Size(145, 18);
            this.Load += new System.EventHandler(this.CustomHScrollBar_Load);
            this.hScrollBar.ResumeLayout(false);
            this.hScrollBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBarThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel hScrollBar;
        public System.Windows.Forms.PictureBox hScrollBarArrowLeft;
        public System.Windows.Forms.PictureBox hScrollBarArrowRight;
        public System.Windows.Forms.PictureBox hScrollBarThumb;
    }
}
