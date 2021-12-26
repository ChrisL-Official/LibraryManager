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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_fine = new System.Windows.Forms.TextBox();
            this.txt_fine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(9, 8);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(372, 34);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录搜索筛选向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(0, 287);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(526, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(363, 20);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(73, 25);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(441, 20);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 25);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 42);
            this.panel1.TabIndex = 4;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(9, 264);
            this.txt_des.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(505, 21);
            this.txt_des.TabIndex = 13;
            this.txt_des.Text = "留空则不搜索此项；按【重置】按钮重置搜索。";
            // 
            // edit_days
            // 
            this.edit_days.Location = new System.Drawing.Point(61, 181);
            this.edit_days.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_days.Name = "edit_days";
            this.edit_days.Size = new System.Drawing.Size(156, 23);
            this.edit_days.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "时长：";
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(240, 96);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(73, 25);
            this.btn_user.TabIndex = 42;
            this.btn_user.Text = "选择用户...";
            this.btn_user.UseVisualStyleBackColor = true;
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(61, 153);
            this.edit_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(156, 23);
            this.edit_id.TabIndex = 40;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 156);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(54, 17);
            this.txt_id.TabIndex = 39;
            this.txt_id.Text = "学号：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(61, 125);
            this.edit_class.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(156, 23);
            this.edit_class.TabIndex = 38;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(9, 128);
            this.txt_class.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(54, 17);
            this.txt_class.TabIndex = 37;
            this.txt_class.Text = "班级：";
            // 
            // edit_uname
            // 
            this.edit_uname.Location = new System.Drawing.Point(61, 97);
            this.edit_uname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_uname.Name = "edit_uname";
            this.edit_uname.Size = new System.Drawing.Size(156, 23);
            this.edit_uname.TabIndex = 36;
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(9, 100);
            this.txt_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(54, 17);
            this.txt_uname.TabIndex = 35;
            this.txt_uname.Text = "姓名：";
            // 
            // edit_bname
            // 
            this.edit_bname.Location = new System.Drawing.Point(61, 68);
            this.edit_bname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_bname.Name = "edit_bname";
            this.edit_bname.Size = new System.Drawing.Size(156, 23);
            this.edit_bname.TabIndex = 34;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(9, 71);
            this.txt_bname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(47, 17);
            this.txt_bname.TabIndex = 33;
            this.txt_bname.Text = "书本：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(221, 72);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(221, 102);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 49;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(221, 130);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 50;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(221, 158);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 51;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(203, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "模糊匹配";
            // 
            // edit_fine
            // 
            this.edit_fine.Location = new System.Drawing.Point(61, 210);
            this.edit_fine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_fine.Name = "edit_fine";
            this.edit_fine.Size = new System.Drawing.Size(156, 23);
            this.edit_fine.TabIndex = 55;
            // 
            // txt_fine
            // 
            this.txt_fine.Location = new System.Drawing.Point(9, 213);
            this.txt_fine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.Size = new System.Drawing.Size(54, 17);
            this.txt_fine.TabIndex = 54;
            this.txt_fine.Text = "罚金：";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(520, 339);
            this.Controls.Add(this.edit_fine);
            this.Controls.Add(this.txt_fine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_fine;
        private System.Windows.Forms.Label txt_fine;
    }
}