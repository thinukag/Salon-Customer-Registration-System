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
    public partial class Client_record : Form
    {
        DataTable data;
        public Client_record()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView();
            DV.RowFilter = string.Format("Date Like '%{0}%'",textBox7.Text);
            dataGridView1.DataSource = DV;

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
            MySqlCommand databaseConnection = new MySqlCommand("insert into `wedding detail` values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox6.Text + "')", con);
            databaseConnection.ExecuteNonQuery();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `wedding detail`", con);
            data = new DataTable();
            sqlda.Fill(data);
            dataGridView1.DataSource = data;
            MessageBox.Show("save");
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Client_record_Load(object sender, EventArgs e)
        {
            string con = "server = localhost; username =root; password = ;database=salon_reg;allowuservariables=True";
            MySqlConnection conn = new MySqlConnection(con);
            conn.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `wedding detail`", conn);
            data = new DataTable();
            sqlda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
