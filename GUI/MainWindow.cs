using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            timer_date.Start();
        }

        private void update_date(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Equals(btn_user)){
                new StudentManagerWindow().ShowDialog();
                return;
            }
        }
    }
}
