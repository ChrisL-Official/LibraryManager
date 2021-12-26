using System;
using System.Runtime.InteropServices;
using System.Text;
using static RunTimeTest.MyUtil;

namespace RunTimeTest
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        extern static IntPtr FreeLibrary(IntPtr handle);

        [DllImport("Core.dll")]
        extern static IntPtr add_item(IntPtr handle);

        [DllImport("Core.dll")]
        extern static IntPtr add_item(IntPtr list, IntPtr data);

        [DllImport("Core.dll")]
        extern static void delete_item(IntPtr p);

        [DllImport("Core.dll")]
        extern static void change_item(IntPtr p, IntPtr data);

        [DllImport("Core.dll")]
        extern static IntPtr get_user_list();

        [DllImport("Core.dll")]
        extern static IntPtr get_penalty_list();

        extern static IntPtr add_user(byte[] u_id, byte[] u_name, byte[] u_class);


        static void Main(string[] args)
        {
            IntPtr handle = LoadLibrary("Core.dll");
            if (handle == IntPtr.Zero)
            {
                Console.WriteLine("Dll未载入");
                return;
            }
            IntPtr p= get_user_list();
            add_user(Encoding.ASCII.GetBytes("123"), Encoding.Unicode.GetBytes("姓名"), Encoding.Unicode.GetBytes("班级"));
            Console.WriteLine("完成");
        }
    }
}
