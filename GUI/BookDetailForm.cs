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
    public partial class BookDetailForm : Form
    {

        [DllImport("Core.dll")]
        extern static int add_book(int uid, byte[] name, byte[] id);

        [DllImport("Core.dll")]
        extern static int edit_book(IntPtr p, byte[] name, byte[] id);

        private IntPtr current = IntPtr.Zero;
        public BookDetailForm()
        {
            InitializeComponent();
        }

        public BookDetailForm(IntPtr p)
        {
            Node n = (Node)Marshal.PtrToStructure(p, typeof(Node));
            current = n.pointer;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (edit_name.Text.Length == 0 || edit_type.Text.Length == 0)
            {
                showWarningMsgbox("所有项都是必填项。");
                return;
            }
            if (!wstr_is_id(Encoding.Unicode.GetBytes(edit_type.Text)))
            {
                showWarningMsgbox("编号只能由数字和大写字母(A-Z)组成。");
                return;
            }
            int i;
            if (current == IntPtr.Zero)
            {
                i = add_book(getUID(),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.ASCII.GetBytes(edit_type.Text));
            }
            else
            {
                i = edit_book(current,
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.ASCII.GetBytes(edit_type.Text));
            }
            if (i != 0)
            {
                showWarningMsgbox("图书已存在或与现有项冲突。");
                return;
            }
            DialogResult = DialogResult.OK;
            MyUtil.PTmp = current;
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            if (current != IntPtr.Zero)
            {
                Book u = (Book)Marshal.PtrToStructure(current, typeof(Book));
                edit_name.Text = Encoding.Unicode.GetString(u.b_name).TrimEnd('\0');
                edit_type.Text = Encoding.ASCII.GetString(u.b_id).TrimEnd('\0');
            }
        }
    }
}
