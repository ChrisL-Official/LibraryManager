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

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg,
            int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        private static extern bool SendMessage(IntPtr hwnd, int msg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        private static extern bool GetComboBoxInfo(IntPtr hwnd, ref COMBOBOXINFO pcbi);

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

        [StructLayout(LayoutKind.Sequential)]
        private struct COMBOBOXINFO
        {
            public int cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public IntPtr stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private const int EM_SETCUEBANNER = 0x1501;
        private const int EM_GETCUEBANNER = 0x1502;

        public static void SetMaxLengthHint(Control control,int max,bool is_id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("最长");
            sb.Append(max);
            sb.Append("字");
            if (is_id)
                sb.Append("，仅支持0-9和A-Z");
            SetHint(control, sb.ToString());
        }

        public static void SetHint(Control control, string text)
        {
            if (control is ComboBox)
            {
                COMBOBOXINFO info = GetComboBoxInfo(control);
                SendMessage(info.hwndItem, EM_SETCUEBANNER, 0, text);
            }
            else
            {
                SendMessage(control.Handle, EM_SETCUEBANNER, 0, text);
            }
        }

        private static COMBOBOXINFO GetComboBoxInfo(Control control)
        {
            COMBOBOXINFO info = new COMBOBOXINFO();
            //a combobox is made up of three controls, a button, a list and textbox;
            //we want the textbox
            info.cbSize = Marshal.SizeOf(info);
            GetComboBoxInfo(control.Handle, ref info);
            return info;
        }

        public static string GetHint(Control control)
        {
            StringBuilder builder = new StringBuilder();
            if (control is ComboBox)
            {
                COMBOBOXINFO info = new COMBOBOXINFO();
                //a combobox is made up of two controls, a list and textbox;
                //we want the textbox
                info.cbSize = Marshal.SizeOf(info);
                GetComboBoxInfo(control.Handle, ref info);
                SendMessage(info.hwndItem, EM_GETCUEBANNER, 0, builder);
            }
            else
            {
                SendMessage(control.Handle, EM_GETCUEBANNER, 0, builder);
            }
            return builder.ToString();
        }
    }
}
