
namespace GUI
{
    partial class StudentManagerWindow
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
            this.list = new System.Windows.Forms.ListView();
            this.col_check = new System.Windows.Forms.ColumnHeader();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_name = new System.Windows.Forms.ColumnHeader();
            this.col_class = new System.Windows.Forms.ColumnHeader();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.group_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.combo_search = new System.Windows.Forms.ComboBox();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.group_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.CheckBoxes = true;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_check,
            this.col_id,
            this.col_name,
            this.col_class});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(388, 330);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // col_check
            // 
            this.col_check.Width = 30;
            // 
            // col_id
            // 
            this.col_id.Text = "学号";
            this.col_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_id.Width = 130;
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(406, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(136, 29);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "新增...";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(406, 48);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(136, 29);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "修改...";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(406, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(136, 29);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_click);
            // 
            // group_search
            // 
            this.group_search.Controls.Add(this.btn_search);
            this.group_search.Controls.Add(this.combo_search);
            this.group_search.Controls.Add(this.edit_search);
            this.group_search.Location = new System.Drawing.Point(406, 118);
            this.group_search.Name = "group_search";
            this.group_search.Size = new System.Drawing.Size(136, 134);
            this.group_search.TabIndex = 4;
            this.group_search.TabStop = false;
            this.group_search.Text = "搜索";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(6, 94);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 29);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_click);
            // 
            // combo_search
            // 
            this.combo_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_search.FormattingEnabled = true;
            this.combo_search.Items.AddRange(new object[] {
            "学号",
            "姓名",
            "班级"});
            this.combo_search.Location = new System.Drawing.Point(6, 60);
            this.combo_search.Name = "combo_search";
            this.combo_search.Size = new System.Drawing.Size(124, 28);
            this.combo_search.TabIndex = 1;
            // 
            // edit_search
            // 
            this.edit_search.Location = new System.Drawing.Point(6, 26);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(124, 27);
            this.edit_search.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(412, 312);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(130, 29);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "选择此项";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Visible = false;
            this.btn_select.Click += new System.EventHandler(this.btn_click);
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Location = new System.Drawing.Point(18, 18);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(18, 17);
            this.chk_all.TabIndex = 7;
            this.chk_all.UseVisualStyleBackColor = true;
            // 
            // StudentManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.group_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentManagerWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.StudentManagerWindow_Load);
            this.group_search.ResumeLayout(false);
            this.group_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox group_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combo_search;
        private System.Windows.Forms.TextBox edit_search;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.ColumnHeader col_check;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_class;
    }
}