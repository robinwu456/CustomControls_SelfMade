namespace CustomPicButton {
    partial class CustomPicButton {
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
            this.picBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtn
            // 
            this.picBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBtn.Image = global::CustomPicButton.Properties.Resources.確定;
            this.picBtn.Location = new System.Drawing.Point(0, 0);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(60, 30);
            this.picBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtn.TabIndex = 0;
            this.picBtn.TabStop = false;
            // 
            // CustomPicButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBtn);
            this.Name = "CustomPicButton";
            this.Size = new System.Drawing.Size(60, 30);
            this.Load += new System.EventHandler(this.CustomPicButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBtn;
    }
}
