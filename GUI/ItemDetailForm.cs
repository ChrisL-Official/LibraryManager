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
    public partial class ItemDetailForm : Form
    {
        [DllImport("Core.dll")]
        extern static int add_penalty(IntPtr user, IntPtr book, byte[] b_name, byte[] b_id, byte[] u_id, byte[] u_name, byte[] u_class, ushort days);

        [DllImport("Core.dll")]
        extern static int edit_penalty(IntPtr penalty, IntPtr user, IntPtr book, byte[] b_name, byte[] b_id, byte[] u_id, byte[] u_name, byte[] u_class, ushort days);

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_pure_numberic(byte[] str);

        [DllImport("Core.dll")]
        extern static ushort wstr_to_short(byte[] str);

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_id(byte[] str);

        private IntPtr current = IntPtr.Zero;
        private IntPtr user = IntPtr.Zero;
        private IntPtr book = IntPtr.Zero;

        public ItemDetailForm(IntPtr p)
        {
            Node n = (Node)Marshal.PtrToStructure(p, typeof(Node));
            current = n.pointer;
            InitializeComponent();
        }

        public ItemDetailForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(edit_type.Text.Length == 0||
                edit_bname.Text.Length==0||
                edit_uname.Text.Length == 0||
                edit_class.Text.Length==0||
                edit_id.Text.Length==0||
                edit_days.Text.Length==0)
            {
                MyUtil.showWarningMsgbox("所有项都是必填项。");
                return;
            }
            if (!wstr_is_pure_numberic(Encoding.Unicode.GetBytes(edit_days.Text))
                ||Convert.ToInt32(edit_days.Text)==0)
            {
                MyUtil.showWarningMsgbox("天数只能是大于0的纯数字。");
                return;
            }
            if (!wstr_is_id(Encoding.Unicode.GetBytes(edit_id.Text)))
            {
                MyUtil.showWarningMsgbox("ID只能由数字和大写字母(A-Z)组成。");
                return;
            }
            if (current==IntPtr.Zero)
            {

                /*current = add_item(Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    2);*/
                int i = add_penalty(user, book,
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    Encoding.ASCII.GetBytes(edit_type.Text),
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    wstr_to_short(Encoding.Unicode.GetBytes(edit_days.Text)));
                if(i!=(int)StatusCode.SUCCESS)
                {
                    MyUtil.showErrorMsgbox("添加失败。");
                    return;
                }
                DialogResult = DialogResult.OK;
                MyUtil.PTmp = current;
            }
            else
            {
                int i = edit_penalty(current, user, book,
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    Encoding.ASCII.GetBytes(edit_type.Text),
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    wstr_to_short(Encoding.Unicode.GetBytes(edit_days.Text)));
                if (i != (int)StatusCode.SUCCESS)
                {
                    MyUtil.showErrorMsgbox("修改失败。");
                    return;
                }
                DialogResult = DialogResult.OK;
            }
            Dispose();
        }

        private void ItemDetailForm_Load(object sender, EventArgs e)
        {
            if (current != IntPtr.Zero)
            {
                Penalty p = (Penalty)Marshal.PtrToStructure(current, typeof(Penalty));
                User u = (User)Marshal.PtrToStructure(p.user, typeof(User));
                Book b = (Book)Marshal.PtrToStructure(p.book, typeof(Book));
                edit_bname.Text = Encoding.Unicode.GetString(b.b_name).TrimEnd('\0');
                edit_uname.Text = Encoding.Unicode.GetString(u.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(u.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(u.u_id).TrimEnd('\0');
                edit_type.Text = Encoding.ASCII.GetString(b.b_id).TrimEnd('\0');
                edit_days.Text = Convert.ToString(p.days);
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserManagerForm form = new UserManagerForm(true);
            if(form.ShowDialog() == DialogResult.OK)
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

        private void btn_book_Click(object sender, EventArgs e)
        {
            BookManagerForm form = new BookManagerForm(true);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                Node n = (Node)Marshal.PtrToStructure(PTmp, typeof(Node));
                Book b = (Book)Marshal.PtrToStructure(n.pointer, typeof(Book));
                edit_bname.Text = Encoding.Unicode.GetString(b.b_name).TrimEnd('\0');
                edit_type.Text = Encoding.ASCII.GetString(b.b_id).TrimEnd('\0');
                book = n.pointer;
            }
        }
    }
}
