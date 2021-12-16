using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    class MyUtil
    {
        public enum LoginStatus
        {
            SUCCESS,
            WRONG,
            NOT_EXIST
        }

        public static void showWarningMsgbox(String msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void showErrorMsgbox(String msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
