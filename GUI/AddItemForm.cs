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
    public partial class AddItemForm : Form
    {
        [DllImport("Core.dll")]
        extern static IntPtr add_item(byte[] id, byte[] u_name, byte[] u_class, byte[] b_name, int day, float u_prise);

        [DllImport("Core.dll")]
        extern static IntPtr change_item(IntPtr p,byte[] id, byte[] u_name, byte[] u_class, byte[] b_name, int day, float u_prise);
        
        private IntPtr current;
        public AddItemForm(IntPtr p)
        {
            InitializeComponent();
            if(p!=IntPtr.Zero)
            {
                current = p;
                Item i = (Item)Marshal.PtrToStructure(p, typeof(Item));
                edit_id.Text = Encoding.ASCII.GetString(i.id);
                edit_name.Text = Encoding.Unicode.GetString(i.user_name);
                edit_class.Text = Encoding.Unicode.GetString(i.user_class);
                edit_book.Text = Encoding.Unicode.GetString(i.book_name);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(current==IntPtr.Zero)
            {
                IntPtr p = add_item(
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_book.Text),
                    2, 0);
                if (p == IntPtr.Zero)
                {
                    MyUtil.showErrorMsgbox("无法新建");
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    MyUtil.ptr = p;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                change_item(current,
                    Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_name.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_book.Text),
                    2, 0);
            }
            this.Dispose();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
