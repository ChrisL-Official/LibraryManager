using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RunTimeTest
{
    class MyUtil
    {
        public enum LoginStatus
        {
            SUCCESS,
            WRONG,
            NOT_EXIST
        }

        public struct User
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] u_name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public byte[] u_class;
            //public IntPtr pervious;
            //public IntPtr next;
        };

        public struct Penalty
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] b_name;
            public IntPtr p_user;
            public ushort days;
            public float fine;
        }

        public struct LinkedList
        {
            IntPtr head;
            IntPtr tail;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Union
        {
            [FieldOffset(0)]
            User user;
            [FieldOffset(0)]
            Penalty Penalty;
        }
    }
}
