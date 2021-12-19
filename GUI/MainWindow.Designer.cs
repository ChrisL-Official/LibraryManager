
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "qqq"}, -1);
            this.bar_status = new System.Windows.Forms.StatusStrip();
            this.txt_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.txt_heading = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.txt_user = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.group_user = new System.Windows.Forms.GroupBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bar_status.SuspendLayout();
            this.group_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_status
            // 
            this.bar_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_info,
            this.txt_time,
            this.toolStripDropDownButton1});
            this.bar_status.Location = new System.Drawing.Point(0, 403);
            this.bar_status.Name = "bar_status";
            this.bar_status.Size = new System.Drawing.Size(702, 30);
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
            this.txt_heading.Size = new System.Drawing.Size(478, 65);
            this.txt_heading.TabIndex = 1;
            this.txt_heading.Text = "借阅图书超期管理系统";
            this.txt_heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(678, 280);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(496, 80);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜索...";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 79);
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
            this.btn_delete.Location = new System.Drawing.Point(213, 79);
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
            this.btn_edit.Location = new System.Drawing.Point(113, 79);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 29);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "修改...";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // timer_date
            // 
            this.timer_date.Interval = 1000;
            this.timer_date.Tick += new System.EventHandler(this.update_date);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(6, 26);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(82, 25);
            this.txt_user.TabIndex = 0;
            this.txt_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(100, 22);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(88, 29);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "登出";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // group_user
            // 
            this.group_user.Controls.Add(this.btn_logout);
            this.group_user.Controls.Add(this.txt_user);
            this.group_user.Location = new System.Drawing.Point(496, 9);
            this.group_user.Name = "group_user";
            this.group_user.Size = new System.Drawing.Size(194, 65);
            this.group_user.TabIndex = 9;
            this.group_user.TabStop = false;
            this.group_user.Text = "用户";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(596, 80);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(94, 29);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.Text = "排序...";
            this.btn_sort.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(699, 352);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(188, 125);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.group_user);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.listView1);
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
            this.group_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bar_status;
        private System.Windows.Forms.Label txt_heading;
        private System.Windows.Forms.ToolStripStatusLabel txt_time;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolStripStatusLabel txt_info;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.GroupBox group_user;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

