
namespace GUI
{
    partial class AddItemForm
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
            this.edit_id = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.edit_class = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.Label();
            this.edit_book = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_days = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_uprise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(71, 6);
            this.edit_id.MaxLength = 10;
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(200, 27);
            this.edit_id.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(62, 25);
            this.txt_id.TabIndex = 2;
            this.txt_id.Text = "学号：";
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(71, 39);
            this.edit_name.MaxLength = 4;
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(200, 27);
            this.edit_name.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 42);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(62, 25);
            this.txt_name.TabIndex = 4;
            this.txt_name.Text = "姓名：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(71, 72);
            this.edit_class.MaxLength = 10;
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(200, 27);
            this.edit_class.TabIndex = 7;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(12, 75);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(62, 25);
            this.txt_class.TabIndex = 6;
            this.txt_class.Text = "班级：";
            // 
            // edit_book
            // 
            this.edit_book.Location = new System.Drawing.Point(71, 105);
            this.edit_book.MaxLength = 19;
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(200, 27);
            this.edit_book.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "书籍：";
            // 
            // edit_days
            // 
            this.edit_days.Location = new System.Drawing.Point(71, 138);
            this.edit_days.MaxLength = 10;
            this.edit_days.Name = "edit_days";
            this.edit_days.Size = new System.Drawing.Size(200, 27);
            this.edit_days.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "天数：";
            // 
            // edit_uprise
            // 
            this.edit_uprise.Location = new System.Drawing.Point(71, 171);
            this.edit_uprise.MaxLength = 10;
            this.edit_uprise.Name = "edit_uprise";
            this.edit_uprise.Size = new System.Drawing.Size(200, 27);
            this.edit_uprise.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "单价：";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(12, 202);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(259, 30);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 241);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.edit_uprise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_class);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.edit_id);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "超期记录";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.TextBox edit_class;
        private System.Windows.Forms.Label txt_class;
        private System.Windows.Forms.TextBox edit_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edit_days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_uprise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
    }
}