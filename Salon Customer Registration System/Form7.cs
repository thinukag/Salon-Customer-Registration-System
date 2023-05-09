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
    public partial class Form7 : Form
    {
        public Form7()
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
            MySqlCommand databaseConnection = new MySqlCommand("insert into `customer reg` values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MessageBox.Show("save");
            con.Close();
        }
    }
}
