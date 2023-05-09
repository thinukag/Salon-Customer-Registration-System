using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Customer_Registration_System
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client_record f3 = new Client_record();
            f3.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 f3 = new Form6();
            f3.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f3 = new Form7();
            f3.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 f3 = new Form8();
            f3.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f3 = new Login();
            f3.Show();
            this.Visible = false;
        }
    }
}
