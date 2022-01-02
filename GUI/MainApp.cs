using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;

namespace GUI
{
    static class mainApp
    {
        [DllImport("kernel32.dll")]
        extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        extern static IntPtr FreeLibrary(IntPtr handle);

        [DllImport("Core.dll")]
        extern static void init();


        [STAThread]
        static void Main()
        {
            IntPtr handle = LoadLibrary("Core.dll");
            if(handle==IntPtr.Zero)
            {
                MyUtil.showErrorMsgbox("未找到关键文件Core.dll!\n请把Core.dll放入\"" + System.Environment.CurrentDirectory + "\"文件夹。");
                return;
            }
            init();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form f = new LoginForm();
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
            {
                Application.Run(new MainWindow());
            }
            FreeLibrary(handle);
        }
    }
}
