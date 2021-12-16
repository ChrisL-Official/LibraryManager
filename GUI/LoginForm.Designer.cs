
namespace GUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.Label();
            this.edit_account = new System.Windows.Forms.TextBox();
            this.edit_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_cp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(368, 36);
            this.title.TabIndex = 0;
            this.title.Text = "借阅图书超期管理系统";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_account
            // 
            this.txt_account.AutoSize = true;
            this.txt_account.Location = new System.Drawing.Point(13, 61);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(54, 20);
            this.txt_account.TabIndex = 1;
            this.txt_account.Text = "账户：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.AutoSize = true;
            this.txt_pwd.Location = new System.Drawing.Point(13, 101);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(54, 20);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Text = "密码：";
            // 
            // edit_account
            // 
            this.edit_account.Location = new System.Drawing.Point(58, 58);
            this.edit_account.Name = "edit_account";
            this.edit_account.Size = new System.Drawing.Size(235, 27);
            this.edit_account.TabIndex = 3;
            // 
            // edit_pwd
            // 
            this.edit_pwd.Location = new System.Drawing.Point(58, 98);
            this.edit_pwd.Name = "edit_pwd";
            this.edit_pwd.Size = new System.Drawing.Size(235, 27);
            this.edit_pwd.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(309, 58);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(71, 67);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_cp
            // 
            this.txt_cp.AutoSize = true;
            this.txt_cp.Location = new System.Drawing.Point(287, 134);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(93, 20);
            this.txt_cp.TabIndex = 6;
            this.txt_cp.Text = "ChrisL 2022";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 163);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.edit_pwd);
            this.Controls.Add(this.edit_account);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label txt_account;
        private System.Windows.Forms.Label txt_pwd;
        private System.Windows.Forms.TextBox edit_account;
        private System.Windows.Forms.TextBox edit_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label txt_cp;
    }
}