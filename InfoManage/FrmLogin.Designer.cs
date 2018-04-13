namespace InfoManage
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.findpsd = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.rembpsd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户名";
            // 
            // txtPsd
            // 
            this.txtPsd.Location = new System.Drawing.Point(322, 192);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.PasswordChar = '*';
            this.txtPsd.Size = new System.Drawing.Size(166, 21);
            this.txtPsd.TabIndex = 2;
            this.txtPsd.Text = "123456";
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(465, 271);
            this.cancel.Name = "cancel";
            this.cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancel.Size = new System.Drawing.Size(74, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // findpsd
            // 
            this.findpsd.Location = new System.Drawing.Point(303, 271);
            this.findpsd.Name = "findpsd";
            this.findpsd.Size = new System.Drawing.Size(75, 23);
            this.findpsd.TabIndex = 5;
            this.findpsd.Text = "找回密码";
            this.findpsd.UseVisualStyleBackColor = true;
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(222, 271);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 4;
            this.signup.Text = "注册";
            this.signup.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(384, 271);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 3;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(322, 145);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(166, 21);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "admin";
            // 
            // rembpsd
            // 
            this.rembpsd.AutoSize = true;
            this.rembpsd.Checked = true;
            this.rembpsd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rembpsd.Location = new System.Drawing.Point(510, 196);
            this.rembpsd.Name = "rembpsd";
            this.rembpsd.Size = new System.Drawing.Size(72, 16);
            this.rembpsd.TabIndex = 16;
            this.rembpsd.Text = "记住密码";
            this.rembpsd.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rembpsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPsd);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.findpsd);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txtUser);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button findpsd;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox rembpsd;
    }
}

