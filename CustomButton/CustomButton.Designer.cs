namespace CustomButton {
    partial class CustomButton {
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
            this.customPanelBtnBg = new CustomPanel();
            this.lbBtnText = new System.Windows.Forms.Label();
            this.customPanelBtnBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanelBtnBg
            // 
            this.customPanelBtnBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.customPanelBtnBg.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(61)))));
            this.customPanelBtnBg.Controls.Add(this.lbBtnText);
            this.customPanelBtnBg.Curvature = 4;
            this.customPanelBtnBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanelBtnBg.ForeColor = System.Drawing.Color.Transparent;
            this.customPanelBtnBg.GradientMode = LinearGradientMode.Horizontal;
            this.customPanelBtnBg.Location = new System.Drawing.Point(0, 0);
            this.customPanelBtnBg.Name = "customPanelBtnBg";
            this.customPanelBtnBg.Size = new System.Drawing.Size(60, 30);
            this.customPanelBtnBg.TabIndex = 0;
            // 
            // lbBtnText
            // 
            this.lbBtnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBtnText.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbBtnText.ForeColor = System.Drawing.Color.Transparent;
            this.lbBtnText.Location = new System.Drawing.Point(0, 0);
            this.lbBtnText.Name = "lbBtnText";
            this.lbBtnText.Size = new System.Drawing.Size(60, 30);
            this.lbBtnText.TabIndex = 0;
            this.lbBtnText.Text = "button";
            this.lbBtnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customPanelBtnBg);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(60, 30);
            this.customPanelBtnBg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public CustomPanel customPanelBtnBg;
        public System.Windows.Forms.Label lbBtnText;
    }
}
