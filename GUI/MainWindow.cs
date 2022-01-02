using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.MyUtil;

namespace GUI
{
    public partial class MainWindow : Form
    {
        [DllImport("Core.dll")]
        extern static IntPtr get_penaltys();

        [DllImport("Core.dll")]
        extern static IntPtr get_penalty_list();

        [DllImport("Core.dll")]
        extern static void fresh_penalty_list();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            fresh_penalty_list();
            list_main.BeginUpdate();
            list_main.Items.Clear();
            IntPtr p = get_penaltys();
            while (p!=IntPtr.Zero)
            {
                p = AddItem(p);
            }
            list_main.EndUpdate();
            if (list_main.Items.Count == 0)
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
            }
            UpdateButtons();
        }

        private IntPtr AddItem(IntPtr ptr)
        {
            Node n = (Node)Marshal.PtrToStructure(ptr, typeof(Node));
            Penalty p = (Penalty)Marshal.PtrToStructure(n.pointer, typeof(Penalty));
            User u = (User)Marshal.PtrToStructure(p.user, typeof(User));
            Book b = (Book)Marshal.PtrToStructure(p.book,typeof(Book));
            ListViewItem item = new ListViewItem(Convert.ToString(list_main.Items.Count + 1));
            item.SubItems.Add(Encoding.ASCII.GetString(u.u_id).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(u.u_name).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(u.u_class).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(b.b_name).TrimEnd('\0'));
            item.SubItems.Add(Encoding.ASCII.GetString(b.b_id).TrimEnd('\0'));
            item.SubItems.Add(Convert.ToString(p.days));
            item.SubItems.Add(Convert.ToString(p.fine));
            item.Tag = ptr;
            list_main.Items.Add(item);
            return n.next;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer_date.Start();
            UpdateList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int j = list_main.SelectedItems.Count;
            for (int i=0;i<j;i++)
            {
                delete_item(get_penalty_list(),(IntPtr)list_main.SelectedItems[i].Tag);
            }
            UpdateList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /*add_item(Encoding.ASCII.GetBytes("3121009997"),
                Encoding.Unicode.GetBytes("梁斯俊"),
                Encoding.Unicode.GetBytes("21计科2"),
                Encoding.Unicode.GetBytes("我的世界"),2);
            UpdateList();*/
            ItemDetailForm form = new ItemDetailForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                UpdateList();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ItemDetailForm form = new ItemDetailForm((IntPtr)list_main.SelectedItems[0].Tag);
            form.ShowDialog();
        }

        private void UpdateDate(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserManagerForm(false).ShowDialog();
        }

        private void list_Selected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateButtons();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            SortForm sortForm = new SortForm();
            sortForm.ShowDialog();
        }

        private void UpdateButtons()
        {
            if (list_main.SelectedItems.Count == 0)
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
            }
            else
            {
                btn_delete.Enabled = true;
                btn_edit.Enabled = list_main.SelectedItems.Count == 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BookManagerForm(false).ShowDialog();
        }
    }
}
