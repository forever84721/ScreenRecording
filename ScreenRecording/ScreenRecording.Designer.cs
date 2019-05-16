namespace ScreenRecording
{
    partial class ScreenRecording
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Recording = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Recording
            // 
            this.Recording.Location = new System.Drawing.Point(14, 14);
            this.Recording.Margin = new System.Windows.Forms.Padding(5);
            this.Recording.Name = "Recording";
            this.Recording.Size = new System.Drawing.Size(154, 103);
            this.Recording.TabIndex = 0;
            this.Recording.Text = "錄製";
            this.Recording.UseVisualStyleBackColor = true;
            this.Recording.Click += new System.EventHandler(this.Recording_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(187, 14);
            this.Stop.Margin = new System.Windows.Forms.Padding(5);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(148, 103);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ScreenRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 131);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Recording);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScreenRecording";
            this.Text = "ScreenRecording";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Recording;
        private System.Windows.Forms.Button Stop;
    }
}

