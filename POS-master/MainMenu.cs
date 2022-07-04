using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainMenu : UserControl
    {
       // Dashboard db = new Dashboard();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_mm_dashboard_Click(object sender, EventArgs e)
        {
            GlobalData.pageIndex = 0;

            MessageBox.Show(GlobalData.pageIndex.ToString());
        }

        private void btn_mm_users_Click(object sender, EventArgs e)
        {
           // db.PageIndex = 1;
            GlobalData.pageIndex = 1;
            MessageBox.Show(GlobalData.pageIndex.ToString());
        }
    }
}
