namespace CheckKeyBoard
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNowTime = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上一次操作时间";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Location = new System.Drawing.Point(109, 12);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(65, 12);
            this.lblLastTime.TabIndex = 0;
            this.lblLastTime.Text = "00：00：00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "无操作时间";
            // 
            // lblNoTime
            // 
            this.lblNoTime.AutoSize = true;
            this.lblNoTime.Location = new System.Drawing.Point(109, 34);
            this.lblNoTime.Name = "lblNoTime";
            this.lblNoTime.Size = new System.Drawing.Size(65, 12);
            this.lblNoTime.TabIndex = 0;
            this.lblNoTime.Text = "00：00：00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "当前时间";
            // 
            // lblNowTime
            // 
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.Location = new System.Drawing.Point(109, 56);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(65, 12);
            this.lblNowTime.TabIndex = 0;
            this.lblNowTime.Text = "00：00：00";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(59, 92);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(0, 12);
            this.lblTip.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 131);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblNowTime);
            this.Controls.Add(this.lblNoTime);
            this.Controls.Add(this.lblLastTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Label lblTip;
    }
}

