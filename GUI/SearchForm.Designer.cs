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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_bname = new System.Windows.Forms.Label();
            this.edit_bname = new System.Windows.Forms.TextBox();
            this.edit_uname = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.Label();
            this.edit_class = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.Label();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
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
            this.txt_title.Size = new System.Drawing.Size(478, 40);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录搜索筛选向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(455, 23);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(555, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 50);
            this.panel1.TabIndex = 4;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(12, 63);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(60, 20);
            this.txt_bname.TabIndex = 5;
            this.txt_bname.Text = "书本：";
            // 
            // edit_bname
            // 
            this.edit_bname.Location = new System.Drawing.Point(78, 60);
            this.edit_bname.Name = "edit_bname";
            this.edit_bname.Size = new System.Drawing.Size(200, 27);
            this.edit_bname.TabIndex = 6;
            // 
            // edit_uname
            // 
            this.edit_uname.Location = new System.Drawing.Point(78, 93);
            this.edit_uname.Name = "edit_uname";
            this.edit_uname.Size = new System.Drawing.Size(200, 27);
            this.edit_uname.TabIndex = 8;
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(12, 96);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(70, 20);
            this.txt_uname.TabIndex = 7;
            this.txt_uname.Text = "姓名：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(78, 126);
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(200, 27);
            this.edit_class.TabIndex = 10;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(12, 129);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(70, 20);
            this.txt_class.TabIndex = 9;
            this.txt_class.Text = "班级：";
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(78, 159);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(200, 27);
            this.edit_id.TabIndex = 12;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 162);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(70, 20);
            this.txt_id.TabIndex = 11;
            this.txt_id.Text = "学号：";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(12, 226);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(478, 25);
            this.txt_des.TabIndex = 13;
            this.txt_des.Text = "留空则不搜索此项。";
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(284, 59);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(94, 29);
            this.btn_book.TabIndex = 14;
            this.btn_book.Text = "选择图书...";
            this.btn_book.UseVisualStyleBackColor = true;
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(284, 92);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(94, 29);
            this.btn_user.TabIndex = 15;
            this.btn_user.Text = "选择用户...";
            this.btn_user.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(673, 451);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.txt_des);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "超期记录搜索筛选向导";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_bname;
        private System.Windows.Forms.TextBox edit_bname;
        private System.Windows.Forms.TextBox edit_uname;
        private System.Windows.Forms.Label txt_uname;
        private System.Windows.Forms.TextBox edit_class;
        private System.Windows.Forms.Label txt_class;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_des;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_reset;
    }
}