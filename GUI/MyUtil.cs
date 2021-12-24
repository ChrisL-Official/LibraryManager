using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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



        public struct Item
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] u_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] u_class;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] b_name;
            public int days;
            public float fine;
            public IntPtr next;
        };

        public struct PItem
        {
            public IntPtr p;
            public IntPtr next;
        };

        public static IntPtr PTmp = IntPtr.Zero;

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
