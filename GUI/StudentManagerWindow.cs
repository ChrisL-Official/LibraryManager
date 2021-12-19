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
    public partial class StudentManagerWindow : Form
    {

        [DllImport("Core.dll")]
        extern static IntPtr add_user(int id, byte[] name, byte[] class_name);

        public StudentManagerWindow()
        {
            InitializeComponent();
            //IntPtr p = add_user(1, Encoding.Unicode.GetBytes("梁斯俊"), Encoding.Unicode.GetBytes("21计科2"));
            //User user = (User)Marshal.PtrToStructure(p, typeof(User));
            //this.Text = Encoding.Unicode.GetString(user.name);
        }

        private void btn_click(object sender, EventArgs e)
        {
            new StudentItemForm().ShowDialog();
        }

        private void StudentManagerWindow_Load(object sender, EventArgs e)
        {
            combo_search.SelectedIndex = 0;
        }
    }
}
