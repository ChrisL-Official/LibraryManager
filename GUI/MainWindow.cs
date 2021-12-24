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
        extern static IntPtr get_all_items();

        [DllImport("Core.dll")]
        extern static void delete_item(IntPtr p);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            list_main.BeginUpdate();
            list_main.Items.Clear();
            IntPtr p = get_all_items();
            while (p!=IntPtr.Zero)
            {
                p = AddItem(p);
            }
            list_main.EndUpdate();
        }

        private IntPtr AddItem(IntPtr p)
        {
            Item i = (Item)Marshal.PtrToStructure(p, typeof(Item));
            ListViewItem item = new ListViewItem(Convert.ToString(list_main.Items.Count+1));
            item.SubItems.Add(Encoding.ASCII.GetString(i.id).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(i.u_name).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(i.u_class).TrimEnd('\0'));
            item.SubItems.Add(Encoding.Unicode.GetString(i.b_name).TrimEnd('\0'));
            item.SubItems.Add("1234567890123");//ISBN
            item.SubItems.Add(Convert.ToString(i.days));
            item.SubItems.Add(Convert.ToString(i.fine));
            item.Tag = p;
            list_main.Items.Add(item);
            return i.next;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer_date.Start();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int j = list_main.SelectedItems.Count;
            for (int i=0;i<j;i++)
            {
                delete_item((IntPtr)list_main.SelectedItems[i].Tag);
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
            ItemDetailForm form = new ItemDetailForm((IntPtr)list_main.SelectedItems[0].Tag);
            form.ShowDialog();
        }
    }
}
