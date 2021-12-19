
namespace GUI
{
    partial class StudentItemForm
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
            this.txt_id = new System.Windows.Forms.Label();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.edit_class = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(14, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(62, 25);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "学号：";
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(73, 13);
            this.edit_id.MaxLength = 10;
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(150, 27);
            this.edit_id.TabIndex = 1;
            this.edit_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_id_KeyPress);
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(73, 46);
            this.edit_name.MaxLength = 4;
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(150, 27);
            this.edit_name.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(14, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(62, 25);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "姓名：";
            // 
            // edit_class
            // 
            this.edit_class.Location = new System.Drawing.Point(73, 79);
            this.edit_class.MaxLength = 9;
            this.edit_class.Name = "edit_class";
            this.edit_class.Size = new System.Drawing.Size(150, 27);
            this.edit_class.TabIndex = 5;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(14, 82);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(62, 25);
            this.txt_class.TabIndex = 4;
            this.txt_class.Text = "班级：";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(229, 11);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(54, 96);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // StudentItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 117);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.edit_class);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.edit_id);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentItemForm";
            this.Text = "学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.TextBox edit_class;
        private System.Windows.Forms.Label txt_class;
        private System.Windows.Forms.Button btn_confirm;
    }
}