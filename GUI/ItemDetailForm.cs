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
        extern static IntPtr add_item(byte[] id, byte[] u_name, byte[] u_class, byte[] b_name, int days);

        [DllImport("Core.dll")]
        extern static IntPtr change_item(IntPtr p,byte[] id, byte[] u_name, byte[] u_class, byte[] b_name, int days);

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_pure_numberic(byte[] str);

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_id(byte[] str);

        private IntPtr current = IntPtr.Zero;

        public ItemDetailForm(IntPtr p)
        {
            current = p;
            InitializeComponent();
        }

        public ItemDetailForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(edit_bname.Text.Length==0||
                edit_class.Text.Length==0||
                edit_id.Text.Length==0||
                edit_days.Text.Length==0)
            {
                MyUtil.showWarningMsgbox("所有项都是必填项。");
                return;
            }
            if (!wstr_is_pure_numberic(Encoding.Unicode.GetBytes(edit_days.Text)))
            {
                MyUtil.showWarningMsgbox("天数只能是大于0的纯数字。");
                return;
            }
            if (!wstr_is_id(Encoding.Unicode.GetBytes(edit_id.Text)))
            {
                MyUtil.showWarningMsgbox("学号只能由数字和大写字母(A-Z)组成。");
                return;
            }
            if (current==IntPtr.Zero)
            {
                current = add_item(Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    2);
                if(current==IntPtr.Zero)
                {
                    MyUtil.showErrorMsgbox("添加失败。");
                    DialogResult = DialogResult.Abort;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    MyUtil.PTmp = current;
                }
            }
            else
            {
                change_item(current,
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    2);
                DialogResult = DialogResult.OK;
            }
            Dispose();
        }

        private void ItemDetailForm_Load(object sender, EventArgs e)
        {
            if (current != IntPtr.Zero)
            {
                Item i = (Item)Marshal.PtrToStructure(current, typeof(Item));
                edit_bname.Text = Encoding.Unicode.GetString(i.b_name).TrimEnd('\0');
                edit_uname.Text = Encoding.Unicode.GetString(i.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(i.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(i.id).TrimEnd('\0');
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserManagerForm form = new UserManagerForm(true);
            if(form.ShowDialog() == DialogResult.OK)
            {
                User u = (User)Marshal.PtrToStructure(PTmp, typeof(User));
                edit_uname.Text = Encoding.Unicode.GetString(u.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(u.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(u.id).TrimEnd('\0');
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
