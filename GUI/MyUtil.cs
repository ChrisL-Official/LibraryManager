using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    class MyUtil
    {

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        public extern static bool wstr_is_id(byte[] str);

        [DllImport("Core.dll")]
        public extern static void delete_item(IntPtr p, IntPtr p1);

        public enum StatusCode
        {
            SUCCESS,
            WRONG,
            NOT_EXIST,
            CHANGED,
            SAME,
            UNREADABLE,
            UNWRITABLE,
            UNFORMATTABLE,
            MEMORY_FULL,
            CONFLICT,
            FATAL,
        }

        //需严格按照C内布局
        /*public struct Item
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
        };*/

        public struct Node
        {
            public IntPtr pointer;
            public IntPtr pervious;
            public IntPtr next;
        }

        public struct Penalty
        {
            public IntPtr user;
            public IntPtr book;
            public ushort days;
            public float fine;
        }

        public struct Book
        {
            public int uid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] b_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] b_name;
        }

        public struct User
        {
            public int uid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] u_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] u_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] u_class;
        }

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
