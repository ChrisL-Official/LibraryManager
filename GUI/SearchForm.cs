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

        [DllImport("Core.dll")]
        extern static IntPtr get_search_list();

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_illegal_decimal(byte[] str);

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        extern static bool wstr_is_pure_numberic(byte[] str);

        [DllImport("Core.dll")]
        extern static void clear_list(IntPtr list);

        [DllImport("Core.dll")]
        extern static int add_search_str(byte[] str, int type, bool is_fuzzy);

        [DllImport("Core.dll")]
        extern static int add_search_i(byte[] str, int type);

        [DllImport("Core.dll")]
        extern static int add_search_f(byte[] str, int type);


        private MainWindow owner;
        private IntPtr user = IntPtr.Zero;
        private IntPtr book = IntPtr.Zero;

        public SearchForm(AllInfo info)
        {
            InitializeComponent();
            load(info);
            list_fun.SelectedIndex = info.fun;
        }

        private void load(AllInfo info)
        {
            edit_class.Text = info.u_class;
            edit_id.Text = info.u_id;
            edit_type.Text = info.b_id;
            edit_uname.Text = info.u_name;
            edit_bname.Text = info.b_name;
            edit_days.Text = info.days;
            edit_fine.Text = info.fine;
            chk0.Checked = info.chk0;
            chk1.Checked = info.chk1;
            chk2.Checked = info.chk2;
            chk3.Checked = info.chk3;
            chk4.Checked = info.chk4;
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
            if (edit_type.Text.Length == 0 &&
                edit_bname.Text.Length == 0 &&
                edit_uname.Text.Length == 0 &&
                edit_class.Text.Length == 0 &&
                edit_id.Text.Length == 0 &&
                edit_days.Text.Length == 0 &&
                edit_fine.Text.Length == 0)
            {
                MyUtil.showWarningMsgbox("至少搜索一项。");
                return;
            }
            clear_list(get_search_list());
            if (edit_days.Text.Length != 0)
            {
                byte[] b = Encoding.Unicode.GetBytes(edit_days.Text);
                if (wstr_is_pure_numberic(b))
                    add_search_i(b, 5);
                else
                {
                    MyUtil.showWarningMsgbox("天数必须是整数。");
                    return;
                }
            }
            if (edit_fine.Text.Length != 0)
            {
                byte[] b = Encoding.Unicode.GetBytes(edit_fine.Text);
                if(wstr_is_illegal_decimal(b))
                    add_search_f(b, 6);
                else
                {
                    MyUtil.showWarningMsgbox("罚金必须是整数或小数。");
                    return;
                }
            }
            if (edit_id.Text.Length != 0)
                add_search_str(Encoding.ASCII.GetBytes(edit_id.Text), 0, chk4.Checked);
            if (edit_uname.Text.Length != 0)
                add_search_str(Encoding.Unicode.GetBytes(edit_uname.Text), 1, chk2.Checked);
            if (edit_class.Text.Length != 0)
                add_search_str(Encoding.Unicode.GetBytes(edit_class.Text), 2, chk3.Checked);
            if (edit_bname.Text.Length != 0)
                add_search_str(Encoding.Unicode.GetBytes(edit_bname.Text), 3, chk0.Checked);
            if (edit_type.Text.Length != 0)
                add_search_str(Encoding.ASCII.GetBytes(edit_type.Text), 4, chk1.Checked);
            AllInfo info = new AllInfo();
            info.u_class = edit_class.Text;
            info.u_id = edit_id.Text;
            info.u_name = edit_uname.Text;
            info.b_id = edit_type.Text;
            info.b_name = edit_bname.Text;
            info.days = edit_days.Text;
            info.fine = edit_fine.Text;
            info.chk0 = chk0.Checked;
            info.chk1 = chk1.Checked;
            info.chk2 = chk2.Checked;
            info.chk3 = chk3.Checked;
            info.chk4 = chk4.Checked;
            info.fun = list_fun.SelectedIndex;
            owner.allInfo = info;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            MainWindow owner = (MainWindow)Owner;
            owner.allInfo = new AllInfo();
            Dispose();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            owner = (MainWindow)Owner;
            btn_reset.Enabled = owner.is_searching;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            AllInfo i = new AllInfo();
            user = IntPtr.Zero;
            book = IntPtr.Zero;
            load(i);
            owner.allInfo = i;
        }
    }
}
