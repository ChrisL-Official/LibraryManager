
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.bar_status = new System.Windows.Forms.StatusStrip();
            this.txt_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.txt_heading = new System.Windows.Forms.Label();
            this.list_main = new System.Windows.Forms.ListView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.btn_sort = new System.Windows.Forms.Button();
            this.col_index = new System.Windows.Forms.ColumnHeader();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_name = new System.Windows.Forms.ColumnHeader();
            this.col_class = new System.Windows.Forms.ColumnHeader();
            this.col_book = new System.Windows.Forms.ColumnHeader();
            this.col_days = new System.Windows.Forms.ColumnHeader();
            this.col_fine = new System.Windows.Forms.ColumnHeader();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.bar_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_status
            // 
            this.bar_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_info,
            this.txt_time,
            this.toolStripDropDownButton1});
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // txt_heading
            // 
            this.txt_heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_heading.Location = new System.Drawing.Point(12, 9);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(358, 65);
            this.txt_heading.TabIndex = 1;
            this.txt_heading.Text = "借阅图书超期管理系统";
            this.txt_heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.list_main.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_main.HideSelection = false;
            listViewItem6.StateImageIndex = 0;
            this.list_main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.list_main.Location = new System.Drawing.Point(13, 114);
            this.list_main.Name = "list_main";
            this.list_main.Size = new System.Drawing.Size(757, 280);
            this.list_main.TabIndex = 2;
            this.list_main.UseCompatibleStateImageBehavior = false;
            this.list_main.View = System.Windows.Forms.View.Details;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(676, 80);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜索...";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(76, 80);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "新增...";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(276, 80);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(176, 79);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 29);
            this.btn_edit.TabIndex = 8;
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
            this.btn_sort.Location = new System.Drawing.Point(576, 80);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(94, 29);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.Text = "排序...";
            this.btn_sort.UseVisualStyleBackColor = true;
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
            this.col_class.Width = 120;
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
            this.col_fine.Width = 90;
            // 
            // btn_fresh
            // 
            this.btn_fresh.Location = new System.Drawing.Point(13, 79);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(57, 29);
            this.btn_fresh.TabIndex = 11;
            this.btn_fresh.Text = "button";
            this.btn_fresh.UseVisualStyleBackColor = true;
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(476, 80);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(94, 29);
            this.btn_backup.TabIndex = 12;
            this.btn_backup.Text = "备份...";
            this.btn_backup.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.list_main);
            this.Controls.Add(this.txt_heading);
            this.Controls.Add(this.bar_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 借阅图书超期管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.bar_status.ResumeLayout(false);
            this.bar_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bar_status;
        private System.Windows.Forms.Label txt_heading;
        private System.Windows.Forms.ToolStripStatusLabel txt_time;
        private System.Windows.Forms.ListView list_main;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolStripStatusLabel txt_info;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
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
    }
}

