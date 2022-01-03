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

        [DllImport("Core.dll")]
        extern static void sort(IntPtr list, int type, [MarshalAs(UnmanagedType.I1)] bool is_positive);

        [DllImport("Core.dll")]
        extern static IntPtr search(IntPtr source, IntPtr search);

        [DllImport("Core.dll")]
        extern static IntPtr get_search_list();

        IntPtr current_list = get_penalty_list();
        bool is_searching = false;
        public bool is_positive = true;
        public int sort_type = 0;
        public AllInfo allInfo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            fresh_penalty_list();
            list_main.BeginUpdate();
            list_main.Items.Clear();
            LinkedList list = (LinkedList)Marshal.PtrToStructure(current_list, typeof(LinkedList));
            IntPtr p;
            if(!is_searching)
            {
                Node node = (Node)Marshal.PtrToStructure(list.head, typeof(Node));
                p = node.next;
            }else
                p = list.head;
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
            SearchForm form = new SearchForm(allInfo);
            form.Owner = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                is_searching = true;
                current_list = search(get_penalty_list(), get_search_list());
                UpdateList();
            }
            else if (form.DialogResult == DialogResult.Abort)
            {
                is_searching = false;
                current_list = get_penalty_list();
                UpdateList();
            }
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
            SortForm sortForm = new SortForm(sort_type,is_positive);
            sortForm.Owner = this;
            sortForm.ShowDialog();
            if (sortForm.DialogResult == DialogResult.OK)
            {
                sort(current_list, sort_type, is_positive);
                UpdateList();
            }
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
