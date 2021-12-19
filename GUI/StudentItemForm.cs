using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static GUI.MyUtil;

namespace GUI
{
    public partial class StudentItemForm : Form
    {
        [DllImport("Core.dll")]
        extern static IntPtr add_user(byte[] id, byte[] name, byte[] class_name);

        [DllImport("Core.dll")]
        extern static bool str_is_numberic(byte[] str, int length);

        public StudentItemForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            IntPtr p = add_user(Encoding.Unicode.GetBytes(edit_id.Text), Encoding.Unicode.GetBytes(edit_name.Text), Encoding.Unicode.GetBytes(edit_class.Text));
            User user = (User)Marshal.PtrToStructure(p, typeof(User));
            this.Text = Encoding.Unicode.GetString(user.name);
        }

        private void edit_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
