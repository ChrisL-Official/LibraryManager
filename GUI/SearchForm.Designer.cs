namespace GUI
{
    partial class SearchForm
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_des = new System.Windows.Forms.Label();
            this.edit_days = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_user = new System.Windows.Forms.Button();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.edit_class = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.Label();
            this.edit_uname = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.Label();
            this.edit_bname = new System.Windows.Forms.TextBox();
            this.txt_bname = new System.Windows.Forms.Label();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_fine = new System.Windows.Forms.TextBox();
            this.txt_fine = new System.Windows.Forms.Label();
            this.edit_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.list_fun = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(12, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(478, 40);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录搜索统计向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(676, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 24);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(467, 24);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(567, 24);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "确定";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 49);
            this.panel1.TabIndex = 4;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(6, 58);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(178, 214);
            this.txt_des.TabIndex = 13;
            this.txt_des.Text = "留空则不搜索此项。\r\n>搜索：\r\n按【重置】按钮清空搜索选项。\r\n>统计罚金：\r\n将会统计所有符合条件项的罚金。";
            // 
            // edit_days
            // 
            this.edit_days.Location = new System.Drawing.Point(78, 247);
            this.edit_days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_days.Name = "edit_days";
            this.edit_days.Size = new System.Drawing.Size(199, 27);
            this.edit_days.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "时长：";
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(309, 147);
            this.btn_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(94, 29);
            this.btn_user.TabIndex = 11;
            this.btn_user.Text = "选择用户...";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(78, 214);
            this.edit_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(199, 27);
            this.edit_id.TabIndex = 9;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 218);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(69, 20);
            this.txt_id.TabIndex = 39;
            this.txt_id.Text = "学号：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(78, 181);
            this.edit_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(199, 27);
            this.edit_class.TabIndex = 7;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(12, 185);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(69, 20);
            this.txt_class.TabIndex = 37;
            this.txt_class.Text = "班级：";
            // 
            // edit_uname
            // 
            this.edit_uname.Location = new System.Drawing.Point(78, 148);
            this.edit_uname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_uname.Name = "edit_uname";
            this.edit_uname.Size = new System.Drawing.Size(199, 27);
            this.edit_uname.TabIndex = 5;
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(12, 152);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(69, 20);
            this.txt_uname.TabIndex = 35;
            this.txt_uname.Text = "姓名：";
            // 
            // edit_bname
            // 
            this.edit_bname.Location = new System.Drawing.Point(78, 80);
            this.edit_bname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_bname.Name = "edit_bname";
            this.edit_bname.Size = new System.Drawing.Size(199, 27);
            this.edit_bname.TabIndex = 0;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(12, 84);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(60, 20);
            this.txt_bname.TabIndex = 33;
            this.txt_bname.Text = "图书：";
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(284, 85);
            this.chk0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(18, 17);
            this.chk0.TabIndex = 1;
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(284, 154);
            this.chk2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(18, 17);
            this.chk2.TabIndex = 6;
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(284, 187);
            this.chk3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(18, 17);
            this.chk3.TabIndex = 8;
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(284, 220);
            this.chk4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(18, 17);
            this.chk4.TabIndex = 10;
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(261, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "模糊匹配";
            // 
            // edit_fine
            // 
            this.edit_fine.Location = new System.Drawing.Point(78, 281);
            this.edit_fine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_fine.Name = "edit_fine";
            this.edit_fine.Size = new System.Drawing.Size(199, 27);
            this.edit_fine.TabIndex = 13;
            // 
            // txt_fine
            // 
            this.txt_fine.Location = new System.Drawing.Point(12, 285);
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.Size = new System.Drawing.Size(69, 20);
            this.txt_fine.TabIndex = 54;
            this.txt_fine.Text = "罚金：";
            // 
            // edit_type
            // 
            this.edit_type.Location = new System.Drawing.Point(78, 114);
            this.edit_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_type.Name = "edit_type";
            this.edit_type.Size = new System.Drawing.Size(199, 27);
            this.edit_type.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "类型：";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(284, 120);
            this.chk1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(18, 17);
            this.chk1.TabIndex = 3;
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(309, 79);
            this.btn_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(94, 29);
            this.btn_book.TabIndex = 4;
            this.btn_book.Text = "选择图书...";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // list_fun
            // 
            this.list_fun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_fun.FormattingEnabled = true;
            this.list_fun.Items.AddRange(new object[] {
            "搜索",
            "统计罚金"});
            this.list_fun.Location = new System.Drawing.Point(6, 23);
            this.list_fun.Name = "list_fun";
            this.list_fun.Size = new System.Drawing.Size(178, 28);
            this.list_fun.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_fun);
            this.groupBox2.Controls.Add(this.txt_des);
            this.groupBox2.Location = new System.Drawing.Point(467, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 278);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(367, 305);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 58;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(669, 399);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.edit_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_fine);
            this.Controls.Add(this.txt_fine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk0);
            this.Controls.Add(this.edit_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.edit_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.edit_class);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.edit_uname);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.edit_bname);
            this.Controls.Add(this.txt_bname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "超期记录搜索统计向导";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_des;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox edit_days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox edit_class;
        private System.Windows.Forms.Label txt_class;
        private System.Windows.Forms.TextBox edit_uname;
        private System.Windows.Forms.Label txt_uname;
        private System.Windows.Forms.TextBox edit_bname;
        private System.Windows.Forms.Label txt_bname;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_fine;
        private System.Windows.Forms.Label txt_fine;
        private System.Windows.Forms.TextBox edit_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox list_fun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
    }
}