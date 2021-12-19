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

        //在C中的所有数组都是指针
        public struct User
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] class_name;
            public IntPtr pwd;
            IntPtr next;
        }

        public struct Book
        {
            public int id;
            public IntPtr name;
        }

        public struct Item
        {
            public IntPtr user;
            public IntPtr book;
            public int date;
            public float u_prise;  //单价
            IntPtr next;
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
