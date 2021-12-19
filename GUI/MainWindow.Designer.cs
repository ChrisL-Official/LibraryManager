
namespace GUI
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bar_status = new System.Windows.Forms.StatusStrip();
            this.txt_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_heading = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.group_tool = new System.Windows.Forms.GroupBox();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.group_user = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.col_check = new System.Windows.Forms.ColumnHeader();
            this.col_user_id = new System.Windows.Forms.ColumnHeader();
            this.col_user_name = new System.Windows.Forms.ColumnHeader();
            this.col_user_class = new System.Windows.Forms.ColumnHeader();
            this.col_book_name = new System.Windows.Forms.ColumnHeader();
            this.col_days = new System.Windows.Forms.ColumnHeader();
            this.col_fee = new System.Windows.Forms.ColumnHeader();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.bar_status.SuspendLayout();
            this.group_tool.SuspendLayout();
            this.group_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_status
            // 
            this.bar_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_info,
            this.txt_time});
            this.bar_status.Location = new System.Drawing.Point(0, 423);
            this.bar_status.Name = "bar_status";
            this.bar_status.Size = new System.Drawing.Size(782, 30);
            this.bar_status.SizingGrip = false;
            this.bar_status.TabIndex = 0;
            this.bar_status.Text = "statusStrip1";
            // 
            // txt_info
            // 
            this.txt_info.AutoSize = false;
            this.txt_info.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txt_info.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.txt_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(500, 24);
            this.txt_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = false;
            this.txt_time.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txt_time.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.txt_time.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(200, 24);
            // 
            // txt_heading
            // 
            this.txt_heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_heading.Location = new System.Drawing.Point(12, 9);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(342, 65);
            this.txt_heading.TabIndex = 1;
            this.txt_heading.Text = "借阅图书超期管理系统";
            this.txt_heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(676, 81);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜索...";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(212, 81);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(112, 80);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 29);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "修改...";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer_date
            // 
            this.timer_date.Interval = 1000;
            this.timer_date.Tick += new System.EventHandler(this.update_date);
            // 
            // group_tool
            // 
            this.group_tool.Controls.Add(this.btn_user);
            this.group_tool.Controls.Add(this.btn_book);
            this.group_tool.Location = new System.Drawing.Point(360, 9);
            this.group_tool.Name = "group_tool";
            this.group_tool.Size = new System.Drawing.Size(202, 65);
            this.group_tool.TabIndex = 9;
            this.group_tool.TabStop = false;
            this.group_tool.Text = "额外工具";
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(100, 27);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(94, 29);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "用户管理";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(7, 27);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(87, 29);
            this.btn_book.TabIndex = 0;
            this.btn_book.Text = "图书管理";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(576, 81);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(94, 29);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.Text = "排序...";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(476, 80);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(94, 29);
            this.btn_backup.TabIndex = 12;
            this.btn_backup.Text = "备份...";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 81);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "新增...";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Click);
            // 
            // group_user
            // 
            this.group_user.Controls.Add(this.txt_name);
            this.group_user.Controls.Add(this.btn_logout);
            this.group_user.Location = new System.Drawing.Point(568, 9);
            this.group_user.Name = "group_user";
            this.group_user.Size = new System.Drawing.Size(202, 65);
            this.group_user.TabIndex = 10;
            this.group_user.TabStop = false;
            this.group_user.Text = "用户";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(7, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(95, 25);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "label1";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(108, 27);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(86, 29);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "登出";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_Click);
            // 
            // ListView
            // 
            this.ListView.CheckBoxes = true;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_check,
            this.col_user_id,
            this.col_user_name,
            this.col_user_class,
            this.col_book_name,
            this.col_days,
            this.col_fee});
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(12, 115);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(758, 309);
            this.ListView.TabIndex = 16;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // col_check
            // 
            this.col_check.Text = "";
            this.col_check.Width = 30;
            // 
            // col_user_id
            // 
            this.col_user_id.Text = "学号";
            this.col_user_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_user_id.Width = 130;
            // 
            // col_user_name
            // 
            this.col_user_name.Text = "姓名";
            this.col_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_user_name.Width = 100;
            // 
            // col_user_class
            // 
            this.col_user_class.Text = "班级";
            this.col_user_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_user_class.Width = 120;
            // 
            // col_book_name
            // 
            this.col_book_name.Text = "书籍";
            this.col_book_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_book_name.Width = 200;
            // 
            // col_days
            // 
            this.col_days.Text = "天数";
            this.col_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_fee
            // 
            this.col_fee.Text = "罚款";
            this.col_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_fee.Width = 110;
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Location = new System.Drawing.Point(20, 120);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(18, 17);
            this.chk_all.TabIndex = 17;
            this.chk_all.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.group_user);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.group_tool);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_heading);
            this.Controls.Add(this.bar_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 借阅图书超期管理系统";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.bar_status.ResumeLayout(false);
            this.bar_status.PerformLayout();
            this.group_tool.ResumeLayout(false);
            this.group_user.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bar_status;
        private System.Windows.Forms.Label txt_heading;
        private System.Windows.Forms.ToolStripStatusLabel txt_time;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolStripStatusLabel txt_info;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.GroupBox group_tool;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.GroupBox group_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader col_check;
        private System.Windows.Forms.ColumnHeader col_user_id;
        private System.Windows.Forms.ColumnHeader col_user_name;
        private System.Windows.Forms.ColumnHeader col_user_class;
        private System.Windows.Forms.ColumnHeader col_book_name;
        private System.Windows.Forms.ColumnHeader col_days;
        private System.Windows.Forms.ColumnHeader col_fee;
        private System.Windows.Forms.CheckBox chk_all;
    }
}

