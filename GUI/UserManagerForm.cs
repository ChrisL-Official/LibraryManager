using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static GUI.MyUtil;

namespace GUI
{
    public partial class UserManagerForm : Form
    {
        [DllImport("Core.dll")]
        extern static void delete_user(IntPtr p);

        [DllImport("Core.dll")]
        extern static IntPtr get_all_users();

        public UserManagerForm(bool showbtns)
        {
            InitializeComponent();
            btn_confirm.Visible = showbtns;
            btn_cancel.Visible = showbtns;
        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            UserDetailForm form = new UserDetailForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                UpdateList();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UserDetailForm form = new UserDetailForm((IntPtr)list_main.SelectedItems[0].Tag);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                UpdateList();
            }
        }

        private void UpdateList()
        {
            list_main.BeginUpdate();
            list_main.Items.Clear();
            IntPtr p = get_all_users();
            while (p != IntPtr.Zero)
            {
                p = AddItem(p);
            }
            list_main.EndUpdate();
            if(list_main.Items.Count == 0)
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false; 
            }
        }

        private IntPtr AddItem(IntPtr p)
        {
            User i = (User)Marshal.PtrToStructure(p, typeof(User));
            ListViewItem item = new ListViewItem(Convert.ToString(list_main.Items.Count + 1));
            item.SubItems.Add(Encoding.ASCII.GetString(i.id).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(i.u_name).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(i.u_class).TrimEnd('\0'));
            item.Tag = p;
            list_main.Items.Add(item);
            return i.next;
        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_main.SelectedItems.Count; i++)
            {
                delete_user((IntPtr)list_main.SelectedItems[i].Tag);
            }
            UpdateList();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            MyUtil.PTmp = (IntPtr)list_main.SelectedItems[0].Tag;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void list_Selected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (list_main.SelectedItems.Count == 0)
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
                btn_confirm.Enabled = false;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_edit.Enabled = list_main.SelectedItems.Count==1;
                btn_confirm.Enabled = list_main.SelectedItems.Count == 1;
            }
        }
    }
}
