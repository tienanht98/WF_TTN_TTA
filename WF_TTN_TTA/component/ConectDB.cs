using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_TTN_TTA.component
{
    public partial class ConectDB : Form
    {
        public ConectDB()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAuthentication.SelectedIndex == 0)
            {
                txbUserName.Enabled = false;
                txbPassword.Enabled = false;
            }
            else
            {
                txbUserName.Enabled = true;
                txbUserName.Enabled = true;
            }
        }

        private void btTestConect_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cbbAuthentication.SelectedIndex == 1)
            {
                cbbDBName.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txbServerName.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cbbDBName.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cbbAuthentication.SelectedIndex == 0)
            {
                cbbDBName.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txbServerName.Text + ";Initial Catalog=master;User Id=" + txbUserName.Text + ";Password=" + txbPassword.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;


                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cbbDBName.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
    }
}
