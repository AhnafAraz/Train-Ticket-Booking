using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SE
{
    public partial class Csignup : Form
    {
        C obj1;
        Form obj2;
        public Csignup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj1 = new C();
            obj1.Show();
        }
        string connectionString = "Data Source=DESKTOP-2QLMIOT;Initial Catalog=Train_Table;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Utable( Name, PH, Mail, Uname, Pass) values('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("done!");

            }
            else { MessageBox.Show("Error!"); }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj2 = new Form1();
            obj2.Show();
        }
    }
}
