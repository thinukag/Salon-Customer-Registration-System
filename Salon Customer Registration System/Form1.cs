using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Salon_Customer_Registration_System
{
    public partial class Login : Form
    {
        
        public Login()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lg_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; username =root; password = ;database=salon_reg;allowuservariables=True");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("select username,password from login where username='" + u_name.Text + "' and password = '" + password.Text + "'", con);
            MySqlDataReader dr = databaseConnection.ExecuteReader();
           if(dr.Read())
            {
                Dash f2 = new Dash();
                f2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("invalid username and password");
                u_name.Clear();
                password.Clear();
            }
            con.Close();
        }
    }
}
