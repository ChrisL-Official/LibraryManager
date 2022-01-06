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
    public partial class SaveForm : Form
    {

        [DllImport("Core.dll")]
        extern static int save(bool b);

        public SaveForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int i = save(rad_backup.Checked);
            if(i == (int)StatusCode.UNWRITABLE)
                MyUtil.showErrorMsgbox("无法写入，操作失败。");
            Dispose();
        }
    }
}
