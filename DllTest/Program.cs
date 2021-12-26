using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DllTest
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        extern static IntPtr FreeLibrary(IntPtr handle);

        [DllImport("Core.dll")]
        extern static IntPtr add_user(byte[] u_id, byte[] u_name, byte[] u_class);
        static void Main(string[] args)
        {
            IntPtr handle = LoadLibrary("Core.dll");
            if (handle == IntPtr.Zero)
            {
                Console.WriteLine("Dll未载入");
                return;
            }
            Console.WriteLine("完成");
        }
    }
}
