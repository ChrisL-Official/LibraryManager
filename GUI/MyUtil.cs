using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public class MyUtil
    {

        [DllImport("Core.dll")]
        [return: MarshalAs(UnmanagedType.I1)]
        public extern static bool wstr_is_id(byte[] str);

        [DllImport("Core.dll")]
        public extern static void delete_item(IntPtr p, IntPtr p1, bool free_data);



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

        public struct Node
        {
            public IntPtr pointer;
            public IntPtr pervious;
            public IntPtr next;
        }

        public struct LinkedList
        {
            public IntPtr head;
            public IntPtr tail;
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

        public struct AllInfo
        {
            public string u_id;
            public bool chk0;
            public string u_name;
            public bool chk1;
            public string u_class;
            public bool chk2;
            public string b_id;
            public bool chk3;
            public string b_name;
            public bool chk4;
            public string days;
            public string fine;
            public int fun;
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

        public static void showInfoMsgbox(String msg)
        {
            MessageBox.Show(msg, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int getUID()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(2000, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt32(ts.TotalSeconds);
        }
    }
}
