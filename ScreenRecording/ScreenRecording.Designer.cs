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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FrameRate = new System.Windows.Forms.NumericUpDown();
            this.Quality = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quality)).BeginInit();
            this.SuspendLayout();
            // 
            // Recording
            // 
            this.Recording.Location = new System.Drawing.Point(24, 48);
            this.Recording.Margin = new System.Windows.Forms.Padding(5);
            this.Recording.Name = "Recording";
            this.Recording.Size = new System.Drawing.Size(154, 103);
            this.Recording.TabIndex = 0;
            this.Recording.Text = "Start";
            this.Recording.UseVisualStyleBackColor = true;
            this.Recording.Click += new System.EventHandler(this.Recording_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(188, 48);
            this.Stop.Margin = new System.Windows.Forms.Padding(5);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(148, 103);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FrameRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality";
            // 
            // FrameRate
            // 
            this.FrameRate.Location = new System.Drawing.Point(116, 11);
            this.FrameRate.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.FrameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FrameRate.Name = "FrameRate";
            this.FrameRate.Size = new System.Drawing.Size(57, 29);
            this.FrameRate.TabIndex = 5;
            this.FrameRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Quality
            // 
            this.Quality.Location = new System.Drawing.Point(262, 11);
            this.Quality.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(57, 29);
            this.Quality.TabIndex = 6;
            this.Quality.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ScreenRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 165);
            this.Controls.Add(this.Quality);
            this.Controls.Add(this.FrameRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Recording);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScreenRecording";
            this.Text = "ScreenRecording";
            ((System.ComponentModel.ISupportInitialize)(this.FrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recording;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FrameRate;
        private System.Windows.Forms.NumericUpDown Quality;
    }
}

