namespace GUI
{
    partial class BookDetailForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.edit_type = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Location = new System.Drawing.Point(-2, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(414, 55);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 20);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 25);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(328, 20);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(73, 25);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // edit_type
            // 
            this.edit_type.Location = new System.Drawing.Point(59, 50);
            this.edit_type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_type.Name = "edit_type";
            this.edit_type.Size = new System.Drawing.Size(156, 23);
            this.edit_type.TabIndex = 50;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(7, 52);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(54, 17);
            this.txt_id.TabIndex = 49;
            this.txt_id.Text = "类型：";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(7, 81);
            this.txt_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(54, 17);
            this.txt_uname.TabIndex = 45;
            this.txt_uname.Text = "名称：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 42);
            this.panel1.TabIndex = 44;
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(9, 8);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(392, 34);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = " 图书信息详情";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(59, 79);
            this.edit_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(156, 23);
            this.edit_name.TabIndex = 46;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 297);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edit_type);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书信息详情";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox edit_type;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_uname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.TextBox edit_name;
    }
}