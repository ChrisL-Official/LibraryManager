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
                MyUtil.showErrorMsgbox("δ�ҵ��ؼ��ļ�Core.dll!\n���Core.dll����\"" + System.Environment.CurrentDirectory + "\"�ļ��С�");
                return;
            }
            int i = init();
            if (i == (int)StatusCode.MEMORY_FULL)
            {
                MyUtil.showErrorMsgbox("�ڴ治�㡣");
                return;
            }
            if (i == (int)StatusCode.UNWRITABLE)
            {
                MyUtil.showErrorMsgbox("�޷��ڱ��ļ�����д�롣");
                return;
            }
            if (i == (int)StatusCode.UNREADABLE)
                MyUtil.showWarningMsgbox("��Ŀ��ȡʧ�ܣ������ļ������Ѿ���٣�\n����ɼ������С�");
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
