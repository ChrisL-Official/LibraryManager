
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.bar_status = new System.Windows.Forms.StatusStrip();
            this.txt_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_heading = new System.Windows.Forms.Label();
            this.col_index = new System.Windows.Forms.ColumnHeader();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_name = new System.Windows.Forms.ColumnHeader();
            this.col_class = new System.Windows.Forms.ColumnHeader();
            this.col_book = new System.Windows.Forms.ColumnHeader();
            this.col_days = new System.Windows.Forms.ColumnHeader();
            this.col_fine = new System.Windows.Forms.ColumnHeader();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.list_main = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bar_status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_status
            // 
            this.bar_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_info,
            this.txt_time});
            this.bar_status.Location = new System.Drawing.Point(0, 372);
            this.bar_status.Name = "bar_status";
            this.bar_status.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.bar_status.Size = new System.Drawing.Size(608, 30);
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
            this.txt_info.Size = new System.Drawing.Size(400, 25);
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
            this.txt_time.Size = new System.Drawing.Size(200, 25);
            // 
            // txt_heading
            // 
            this.txt_heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_heading.Location = new System.Drawing.Point(9, 8);
            this.txt_heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(278, 76);
            this.txt_heading.TabIndex = 1;
            this.txt_heading.Text = "超期借阅图书管理系统";
            this.txt_heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // col_index
            // 
            this.col_index.Text = "#";
            this.col_index.Width = 30;
            // 
            // col_id
            // 
            this.col_id.Text = "学号";
            this.col_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_id.Width = 150;
            // 
            // col_name
            // 
            this.col_name.Text = "姓名";
            this.col_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_name.Width = 100;
            // 
            // col_class
            // 
            this.col_class.Text = "班级";
            this.col_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_class.Width = 100;
            // 
            // col_book
            // 
            this.col_book.Text = "书籍";
            this.col_book.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_book.Width = 200;
            // 
            // col_days
            // 
            this.col_days.Text = "天数";
            this.col_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_fine
            // 
            this.col_fine.Text = "罚金";
            this.col_fine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_fine.Width = 100;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(448, 89);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 25);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "筛选搜索...";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(92, 89);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 25);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "新增...";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(226, 89);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(62, 25);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(159, 89);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(62, 25);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "修改...";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // timer_date
            // 
            this.timer_date.Interval = 1000;
            this.timer_date.Tick += new System.EventHandler(this.UpdateDate);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(370, 89);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(73, 25);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "排序...";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_fresh
            // 
            this.btn_fresh.Location = new System.Drawing.Point(9, 89);
            this.btn_fresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(62, 25);
            this.btn_fresh.TabIndex = 0;
            this.btn_fresh.Text = "刷新";
            this.btn_fresh.UseVisualStyleBackColor = true;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(526, 89);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(73, 25);
            this.btn_backup.TabIndex = 6;
            this.btn_backup.Text = "备份...";
            this.btn_backup.UseVisualStyleBackColor = true;
            // 
            // list_main
            // 
            this.list_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_index,
            this.col_id,
            this.col_name,
            this.col_class,
            this.col_book,
            this.col_days,
            this.col_fine});
            this.list_main.FullRowSelect = true;
            this.list_main.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.list_main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list_main.Location = new System.Drawing.Point(9, 119);
            this.list_main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.list_main.Name = "list_main";
            this.list_main.Size = new System.Drawing.Size(590, 250);
            this.list_main.TabIndex = 15;
            this.list_main.UseCompatibleStateImageBehavior = false;
            this.list_main.View = System.Windows.Forms.View.Details;
            this.list_main.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_Selected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(370, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(229, 76);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.list_main);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_heading);
            this.Controls.Add(this.bar_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 超期借阅图书管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.bar_status.ResumeLayout(false);
            this.bar_status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bar_status;
        private System.Windows.Forms.Label txt_heading;
        private System.Windows.Forms.ToolStripStatusLabel txt_time;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolStripStatusLabel txt_info;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.ColumnHeader col_index;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_class;
        private System.Windows.Forms.ColumnHeader col_book;
        private System.Windows.Forms.ColumnHeader col_days;
        private System.Windows.Forms.ColumnHeader col_fine;
        private System.Windows.Forms.Button btn_fresh;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.ListView list_main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

