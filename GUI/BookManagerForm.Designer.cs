namespace GUI
{
    partial class BookManagerForm
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.list_main = new System.Windows.Forms.ListView();
            this.col_index = new System.Windows.Forms.ColumnHeader();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_name = new System.Windows.Forms.ColumnHeader();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(378, 132);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 25);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(378, 101);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 25);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "修改...";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(378, 70);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 25);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "添加...";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // list_main
            // 
            this.list_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_index,
            this.col_id,
            this.col_name});
            this.list_main.FullRowSelect = true;
            this.list_main.HideSelection = false;
            this.list_main.Location = new System.Drawing.Point(11, 12);
            this.list_main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.list_main.Name = "list_main";
            this.list_main.Size = new System.Drawing.Size(363, 280);
            this.list_main.TabIndex = 14;
            this.list_main.UseCompatibleStateImageBehavior = false;
            this.list_main.View = System.Windows.Forms.View.Details;
            this.list_main.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_Selected);
            // 
            // col_index
            // 
            this.col_index.Text = "#";
            this.col_index.Width = 30;
            // 
            // col_id
            // 
            this.col_id.Text = "编号";
            this.col_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_id.Width = 120;
            // 
            // col_name
            // 
            this.col_name.Text = "名称";
            this.col_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_name.Width = 200;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(378, 236);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 25);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_fresh
            // 
            this.btn_fresh.Location = new System.Drawing.Point(378, 12);
            this.btn_fresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(93, 25);
            this.btn_fresh.TabIndex = 19;
            this.btn_fresh.Text = "刷新";
            this.btn_fresh.UseVisualStyleBackColor = true;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Location = new System.Drawing.Point(378, 267);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(93, 25);
            this.btn_confirm.TabIndex = 18;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_main);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书管理";
            this.Activated += new System.EventHandler(this.Fresh);
            this.Load += new System.EventHandler(this.BookManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView list_main;
        private System.Windows.Forms.ColumnHeader col_index;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_fresh;
        private System.Windows.Forms.Button btn_confirm;
    }
}