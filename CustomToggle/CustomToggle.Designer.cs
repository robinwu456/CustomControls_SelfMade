﻿namespace CustomToggle {
    partial class CustomToggle {
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
            this.picToggle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // picToggle
            // 
            this.picToggle.Image = global::CustomToggle.Properties.Resources.toggleOff;
            this.picToggle.Location = new System.Drawing.Point(0, 0);
            this.picToggle.Name = "picToggle";
            this.picToggle.Size = new System.Drawing.Size(34, 20);
            this.picToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picToggle.TabIndex = 1;
            this.picToggle.TabStop = false;
            // 
            // CustomToggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picToggle);
            this.Name = "CustomToggle";
            this.Size = new System.Drawing.Size(34, 21);
            this.Load += new System.EventHandler(this.CustomToggle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picToggle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picToggle;
    }
}
