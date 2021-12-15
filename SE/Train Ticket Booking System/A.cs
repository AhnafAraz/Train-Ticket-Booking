using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SE
{
    public partial class A : Form
    {
        Ainside obj1;
        Form1 obj2;
        public A()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "54321")

            {
                this.Hide();
                obj1 = new Ainside();
                obj1.Show();
            }

            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Insert Information!");
            }

            else
            {
                MessageBox.Show("Wrong Information!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj2 = new Form1();
            obj2.Show();
        }
    }
}
