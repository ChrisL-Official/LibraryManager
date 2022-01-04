namespace GUI
{
    partial class SaveForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_save = new System.Windows.Forms.RadioButton();
            this.rad_backup = new System.Windows.Forms.RadioButton();
            this.chk_penalty = new System.Windows.Forms.CheckBox();
            this.chk_user = new System.Windows.Forms.CheckBox();
            this.chk_book = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Location = new System.Drawing.Point(-2, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(414, 55);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 20);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 25);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(328, 20);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(73, 25);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(9, 8);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(392, 34);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "保存备份向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 42);
            this.panel1.TabIndex = 21;
            // 
            // rad_save
            // 
            this.rad_save.AutoSize = true;
            this.rad_save.Checked = true;
            this.rad_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_save.Location = new System.Drawing.Point(9, 54);
            this.rad_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_save.Name = "rad_save";
            this.rad_save.Size = new System.Drawing.Size(50, 21);
            this.rad_save.TabIndex = 0;
            this.rad_save.TabStop = true;
            this.rad_save.Text = "保存";
            this.rad_save.UseVisualStyleBackColor = true;
            // 
            // rad_backup
            // 
            this.rad_backup.AutoSize = true;
            this.rad_backup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_backup.Location = new System.Drawing.Point(9, 79);
            this.rad_backup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_backup.Name = "rad_backup";
            this.rad_backup.Size = new System.Drawing.Size(50, 21);
            this.rad_backup.TabIndex = 1;
            this.rad_backup.Text = "备份";
            this.rad_backup.UseVisualStyleBackColor = true;
            this.rad_backup.CheckedChanged += new System.EventHandler(this.rad_backup_CheckedChanged);
            // 
            // chk_penalty
            // 
            this.chk_penalty.AutoSize = true;
            this.chk_penalty.Checked = true;
            this.chk_penalty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_penalty.Enabled = false;
            this.chk_penalty.Location = new System.Drawing.Point(28, 104);
            this.chk_penalty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chk_penalty.Name = "chk_penalty";
            this.chk_penalty.Size = new System.Drawing.Size(75, 21);
            this.chk_penalty.TabIndex = 2;
            this.chk_penalty.Text = "超期记录";
            this.chk_penalty.UseVisualStyleBackColor = true;
            // 
            // chk_user
            // 
            this.chk_user.AutoSize = true;
            this.chk_user.Checked = true;
            this.chk_user.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_user.Enabled = false;
            this.chk_user.Location = new System.Drawing.Point(117, 104);
            this.chk_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chk_user.Name = "chk_user";
            this.chk_user.Size = new System.Drawing.Size(51, 21);
            this.chk_user.TabIndex = 3;
            this.chk_user.Text = "用户";
            this.chk_user.UseVisualStyleBackColor = true;
            // 
            // chk_book
            // 
            this.chk_book.AutoSize = true;
            this.chk_book.Checked = true;
            this.chk_book.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_book.Enabled = false;
            this.chk_book.Location = new System.Drawing.Point(207, 104);
            this.chk_book.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chk_book.Name = "chk_book";
            this.chk_book.Size = new System.Drawing.Size(51, 21);
            this.chk_book.TabIndex = 4;
            this.chk_book.Text = "图书";
            this.chk_book.UseVisualStyleBackColor = true;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 297);
            this.Controls.Add(this.chk_book);
            this.Controls.Add(this.chk_user);
            this.Controls.Add(this.chk_penalty);
            this.Controls.Add(this.rad_backup);
            this.Controls.Add(this.rad_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "保存备份向导";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_save;
        private System.Windows.Forms.RadioButton rad_backup;
        private System.Windows.Forms.CheckBox chk_penalty;
        private System.Windows.Forms.CheckBox chk_user;
        private System.Windows.Forms.CheckBox chk_book;
    }
}