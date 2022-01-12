using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using static GUI.MyUtil;

namespace GUI
{
    static class mainApp
    {
        [DllImport("kernel32.dll")]
        extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        extern static IntPtr FreeLibrary(IntPtr handle);

        [DllImport("Core.dll")]
        extern static int init();

        [DllImport("Core.dll")]
        extern static void exit_prepare();


        [STAThread]
        static void Main()
        {
            IntPtr handle = LoadLibrary("Core.dll");
            if(handle==IntPtr.Zero)
            {
                MyUtil.showErrorMsgbox("未找到关键文件Core.dll!\n请把Core.dll放入\"" + System.Environment.CurrentDirectory + "\"文件夹。");
                return;
            }
            int i = init();
            if (i == (int)StatusCode.MEMORY_FULL)
            {
                MyUtil.showErrorMsgbox("内存不足。");
                return;
            }
            if (i == (int)StatusCode.UNWRITABLE)
            {
                MyUtil.showErrorMsgbox("无法在本文件夹下写入。");
                return;
            }
            if (i == (int)StatusCode.UNREADABLE)
                MyUtil.showWarningMsgbox("项目读取失败，部分文件可能已经损毁！\n程序可继续运行。");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form f = new LoginForm();
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
            {
                Application.Run(new MainWindow());
            }
            exit_prepare();
            FreeLibrary(handle);
        }
    }
}
