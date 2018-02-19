namespace sina_qrcode_login
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
            this.components = new System.ComponentModel.Container();
            this.qrcode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_msg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(12, 12);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(180, 180);
            this.qrcode.TabIndex = 0;
            this.qrcode.TabStop = false;
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_msg);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 50);
            this.panel1.TabIndex = 1;
            // 
            // login_msg
            // 
            this.login_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_msg.Location = new System.Drawing.Point(0, 0);
            this.login_msg.Name = "login_msg";
            this.login_msg.Size = new System.Drawing.Size(180, 50);
            this.login_msg.TabIndex = 0;
            this.login_msg.Text = "qrcode msg";
            this.login_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.user_info);
            this.panel2.Location = new System.Drawing.Point(199, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 100);
            this.panel2.TabIndex = 2;
            // 
            // user_info
            // 
            this.user_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_info.Location = new System.Drawing.Point(0, 0);
            this.user_info.Name = "user_info";
            this.user_info.Size = new System.Drawing.Size(81, 100);
            this.user_info.TabIndex = 0;
            this.user_info.Text = "login user info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.qrcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox qrcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_msg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label user_info;
    }
}

