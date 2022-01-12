namespace GUI
{
    partial class SortForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_sort = new System.Windows.Forms.ComboBox();
            this.rad_pos = new System.Windows.Forms.RadioButton();
            this.rad_neg = new System.Windows.Forms.RadioButton();
            this.txt_des = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Location = new System.Drawing.Point(-3, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(532, 65);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(321, 24);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(422, 24);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(94, 29);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 49);
            this.panel1.TabIndex = 19;
            // 
            // txt_title
            // 
            this.txt_title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Location = new System.Drawing.Point(12, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(504, 40);
            this.txt_title.TabIndex = 1;
            this.txt_title.Text = "超期记录排序向导";
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(12, 64);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(69, 20);
            this.txt_type.TabIndex = 42;
            this.txt_type.Text = "类别：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "顺序：";
            // 
            // list_sort
            // 
            this.list_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_sort.FormattingEnabled = true;
            this.list_sort.Items.AddRange(new object[] {
            "学号",
            "姓名",
            "班级",
            "图书",
            "类型",
            "天数",
            "罚金"});
            this.list_sort.Location = new System.Drawing.Point(78, 61);
            this.list_sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_sort.Name = "list_sort";
            this.list_sort.Size = new System.Drawing.Size(199, 28);
            this.list_sort.TabIndex = 0;
            // 
            // rad_pos
            // 
            this.rad_pos.AutoSize = true;
            this.rad_pos.Checked = true;
            this.rad_pos.Location = new System.Drawing.Point(78, 95);
            this.rad_pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_pos.Name = "rad_pos";
            this.rad_pos.Size = new System.Drawing.Size(60, 24);
            this.rad_pos.TabIndex = 1;
            this.rad_pos.TabStop = true;
            this.rad_pos.Text = "正序";
            this.rad_pos.UseVisualStyleBackColor = true;
            // 
            // rad_neg
            // 
            this.rad_neg.AutoSize = true;
            this.rad_neg.Location = new System.Drawing.Point(150, 95);
            this.rad_neg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_neg.Name = "rad_neg";
            this.rad_neg.Size = new System.Drawing.Size(60, 24);
            this.rad_neg.TabIndex = 2;
            this.rad_neg.Text = "倒序";
            this.rad_neg.UseVisualStyleBackColor = true;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(9, 242);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(507, 40);
            this.txt_des.TabIndex = 47;
            this.txt_des.Text = "将在目前显示的表中排序；你可能要重置搜索结果来排序整个表。\r\n你可以直接通过【保存】功能保存排序后的表。\r\n";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 349);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.rad_neg);
            this.Controls.Add(this.rad_pos);
            this.Controls.Add(this.list_sort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "超期记录排序向导";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list_sort;
        private System.Windows.Forms.RadioButton rad_pos;
        private System.Windows.Forms.RadioButton rad_neg;
        private System.Windows.Forms.Label txt_des;
    }
}