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
    public partial class SearchForm : Form
    {
        private IntPtr user = IntPtr.Zero;
        private IntPtr book = IntPtr.Zero;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            BookManagerForm form = new BookManagerForm(true);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Node n = (Node)Marshal.PtrToStructure(PTmp, typeof(Node));
                Book b = (Book)Marshal.PtrToStructure(n.pointer, typeof(Book));
                edit_bname.Text = Encoding.Unicode.GetString(b.b_name).TrimEnd('\0');
                edit_type.Text = Encoding.ASCII.GetString(b.b_id).TrimEnd('\0');
                book = n.pointer;
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserManagerForm form = new UserManagerForm(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Node n = (Node)Marshal.PtrToStructure(PTmp, typeof(Node));
                User u = (User)Marshal.PtrToStructure(n.pointer, typeof(User));
                edit_uname.Text = Encoding.Unicode.GetString(u.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(u.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(u.u_id).TrimEnd('\0');
                user = n.pointer;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
