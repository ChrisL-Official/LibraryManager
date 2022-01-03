using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class SortForm : Form
    {

        public SortForm(int i, bool b)
        {
            InitializeComponent();
            list_sort.SelectedIndex = i;
            rad_pos.Checked = b;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            MainWindow owner = (MainWindow)Owner;
            owner.is_positive = rad_pos.Checked;
            owner.sort_type = list_sort.SelectedIndex;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SortForm_Load(object sender, EventArgs e)
        {

        }
    }
}
