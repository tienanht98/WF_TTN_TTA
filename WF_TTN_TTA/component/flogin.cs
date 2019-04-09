using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_TTN_TTA.component;
using WF_TTN_TTA.Dao;
namespace WF_TTN_TTA
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát","Thông Báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {    if(string.IsNullOrEmpty(txbUserName.Text) || string.IsNullOrEmpty(txbPassWord.Text))
            {
                MessageBox.Show("username va pass ko dc trong", "Thông Báo");
            }
            else
            {
                UserDao user = new UserDao();

                if ((user.login(txbUserName.Text, txbPassWord.Text) != null))
                {
                    fTableManger f = new fTableManger();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập or mậy khẩu ko đúng", "Thông báo");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
