using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SE
{
    
    public partial class Cin : Form
    {
        
        TrainS obj1;
        C obj2;
        C obj3;
        
        public Cin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj1 = new TrainS();
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj2 = new C();
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj3 = new C();
            obj3.Show();
        }
    }
}
