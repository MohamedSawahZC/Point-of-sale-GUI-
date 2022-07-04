using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS
{
    public partial class DashBoard : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));

        int postion_index = 286;
        public DashBoard()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsTable.Rows.Add(
                   new object[]
               {
                    1,
                    "بطاطس",
                    "50",
                    "100",
                }
                   );
            productsTable.Rows.Add(
                   new object[]
               {
                    2,
                    "بتنجان",
                    "50",
                    "100",
                }
                   );
            productsTable.Rows.Add(
                   new object[]
               {
                    3,
                    "تفاح",
                    "50",
                    "100",
                }
                   );
            for (int i = 0; i < 100; i++)
               
                usersTable.Rows.Add(
                new object[]
                {
                    i,
                    "محمود متولي",
                    "izome.kon@gmail.com",
                    "01551196969",
                    "مصر الجديدة",
        }
                );


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
       }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            UsersShow us = new UsersShow();
            us.Show();
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(1);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(0);
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            
            changeMainMenuIndex(1);
        }

        private void changeMainMenuIndex(int i)
        {
            
            panel_index.Location = new Point(341, (postion_index + (i * 59)));
           
            switch (i)
            {
                case 0:
                    Pages.PageIndex = i;
                 
                    break;
                case 1:
                    Pages.PageIndex = i;
                 
                    break;
                case 2:
                    Pages.PageIndex = i;
                   
                    break;
                case 3:
                 
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                   
                    break;
                case 7:
                    Pages.PageIndex = 3;
                   
                    break;
            }
        }

        private void btn_mm_sales_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(2);
        }

        private void btn_mm_reports_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(3);
        }

        private void btn_mm_returns_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(4);
        }

        private void btn_mm_history_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(5);
        }

        private void btn_mm_offers_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(6);
        }

        private void btn_mm_settings_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(7);
        }

        private void bunifuTextBox1_OnIconLeftClick(object sender, EventArgs e)
        {
            MessageBox.Show("SEARCH");
        }

        private void usersTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.StartPosition = FormStartPosition.CenterScreen;
            new PopupEffect.transparentBg(this, addUser);
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.StartPosition = FormStartPosition.CenterScreen;
            new PopupEffect.transparentBg(this, editUser);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.StartPosition = FormStartPosition.CenterScreen;
            new PopupEffect.transparentBg(this, deleteUser);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(0);
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            changeMainMenuIndex(7);
        }
    }
}
