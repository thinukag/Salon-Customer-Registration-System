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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dash f3 = new Dash();
            f3.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = textBox2.Text;
            if (Query == "")
            {
                MessageBox.Show("insert quary");
                return;
            }
            MySqlConnection con = new MySqlConnection("server = localhost; username =root; password = ;database=salon_reg;allowuservariables=True");
            con.Open();
            MySqlCommand databaseConnection = new MySqlCommand("insert into daily_jobs values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            con.Close();
        }
    }
}
