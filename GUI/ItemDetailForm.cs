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

        private IntPtr current;

        public ItemDetailForm(IntPtr p)
        {
            InitializeComponent();
            if(p!=IntPtr.Zero)
            {
                Item i = (Item)Marshal.PtrToStructure(p, typeof(Item));
                edit_bname.Text = Encoding.Unicode.GetString(i.b_name).TrimEnd('\0');
                edit_uname.Text = Encoding.Unicode.GetString(i.u_name).TrimEnd('\0');
                edit_class.Text = Encoding.Unicode.GetString(i.u_class).TrimEnd('\0');
                edit_id.Text = Encoding.ASCII.GetString(i.id).TrimEnd('\0');
                current = p;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(current==IntPtr.Zero)
            {
                add_item(Encoding.ASCII.GetBytes(edit_id.Text),
                    Encoding.Unicode.GetBytes(edit_uname.Text),
                    Encoding.Unicode.GetBytes(edit_class.Text),
                    Encoding.Unicode.GetBytes(edit_bname.Text),
                    2);
                DialogResult = DialogResult.OK;
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
    }
}
