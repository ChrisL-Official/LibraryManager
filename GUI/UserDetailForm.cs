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
    public partial class UserDetailForm : Form
    {
        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_id(byte[] str);

        [DllImport("Core.dll")]
        extern static IntPtr add_user(byte[] id, byte[] u_name, byte[] u_class);

        [DllImport("Core.dll")]
        extern static IntPtr change_user(IntPtr p,byte[] id, byte[] u_name, byte[] u_class);

        private IntPtr current = IntPtr.Zero;
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(IntPtr p)
        {
            current = p;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (edit_name.Text.Length == 0 ||
                edit_class.Text.Length == 0 ||
                edit_id.Text.Length == 0)
            {
                MyUtil.showWarningMsgbox("所有项都是必填项。");
                return;
            }
            if (!wstr_is_id(Encoding.Unicode.GetBytes(edit_id.Text)))
            {
                MyUtil.showWarningMsgbox("学号只能由数字和大写字母(A-Z)组成。");
                return;
            }
            if (current == IntPtr.Zero)
            {
                current = add_user(Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text));
                if (current == IntPtr.Zero)
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
                change_user(current,
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text));
                DialogResult = DialogResult.OK;
            }
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            if (current != IntPtr.Zero)
            {
                User u = (User)Marshal.PtrToStructure(current, typeof(Item));
                edit_name.Text = Encoding.Unicode.GetString(u.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(u.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(u.id).TrimEnd('\0');
            }
        }
    }
}
