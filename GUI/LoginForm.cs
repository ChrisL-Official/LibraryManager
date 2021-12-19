using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        [DllImport("Core.dll")]
        extern static int login(byte[] account, byte[] pwd);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //C#的Byte对应C的unsigned char
            byte[] account = Encoding.ASCII.GetBytes(edit_account.Text);
            byte[] pwd = Encoding.ASCII.GetBytes(edit_pwd.Text);
            if(account.Length==0||pwd.Length==0)
            {
                MyUtil.showWarningMsgbox("账户和密码不能为空");
                return;
            }
            switch (login(account, pwd))
            {
                case (int)MyUtil.LoginStatus.SUCCESS:
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    break;
                case (int)MyUtil.LoginStatus.WRONG:
                    MyUtil.showWarningMsgbox("账户或密码错误");
                    break;
                case (int)MyUtil.LoginStatus.NOT_EXIST:
                    MyUtil.showWarningMsgbox("账户不存在");
                    break;
            }
        }
    }
}
