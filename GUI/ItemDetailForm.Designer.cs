namespace GUI
{
    partial class ItemDetailForm
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
            this.txt_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.edit_class = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.Label();
            this.edit_uname = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.Label();
            this.edit_bname = new System.Windows.Forms.TextBox();
            this.txt_bname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_days = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_type = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(12, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(504, 40);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录详情";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(532, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(321, 24);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(422, 24);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(94, 29);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(284, 130);
            this.btn_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(94, 29);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "选择用户...";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(78, 197);
            this.edit_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(199, 27);
            this.edit_id.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 201);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(69, 20);
            this.txt_id.TabIndex = 24;
            this.txt_id.Text = "学号：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(78, 164);
            this.edit_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(199, 27);
            this.edit_class.TabIndex = 2;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(12, 166);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(69, 20);
            this.txt_class.TabIndex = 22;
            this.txt_class.Text = "班级：";
            // 
            // edit_uname
            // 
            this.edit_uname.Location = new System.Drawing.Point(78, 131);
            this.edit_uname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_uname.Name = "edit_uname";
            this.edit_uname.Size = new System.Drawing.Size(199, 27);
            this.edit_uname.TabIndex = 1;
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(12, 133);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(69, 20);
            this.txt_uname.TabIndex = 20;
            this.txt_uname.Text = "姓名：";
            // 
            // edit_bname
            // 
            this.edit_bname.Location = new System.Drawing.Point(78, 61);
            this.edit_bname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_bname.Name = "edit_bname";
            this.edit_bname.Size = new System.Drawing.Size(199, 27);
            this.edit_bname.TabIndex = 0;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(12, 64);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(60, 20);
            this.txt_bname.TabIndex = 18;
            this.txt_bname.Text = "书本：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 49);
            this.panel1.TabIndex = 17;
            // 
            // edit_days
            // 
            this.edit_days.Location = new System.Drawing.Point(78, 230);
            this.edit_days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_days.Name = "edit_days";
            this.edit_days.Size = new System.Drawing.Size(199, 27);
            this.edit_days.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "时长：";
            // 
            // edit_type
            // 
            this.edit_type.Location = new System.Drawing.Point(78, 96);
            this.edit_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_type.Name = "edit_type";
            this.edit_type.Size = new System.Drawing.Size(199, 27);
            this.edit_type.TabIndex = 30;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(12, 99);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(60, 20);
            this.txt_type.TabIndex = 31;
            this.txt_type.Text = "类别：";
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(284, 61);
            this.btn_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(94, 29);
            this.btn_book.TabIndex = 32;
            this.btn_book.Text = "选择图书...";
            this.btn_book.UseVisualStyleBackColor = true;
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 349);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.edit_type);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.edit_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.edit_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.edit_class);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.edit_uname);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.edit_bname);
            this.Controls.Add(this.txt_bname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "超期记录详情";
            this.Load += new System.EventHandler(this.ItemDetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox edit_class;
        private System.Windows.Forms.Label txt_class;
        private System.Windows.Forms.TextBox edit_uname;
        private System.Windows.Forms.Label txt_uname;
        private System.Windows.Forms.TextBox edit_bname;
        private System.Windows.Forms.Label txt_bname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edit_days;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_type;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Button btn_book;
    }
}