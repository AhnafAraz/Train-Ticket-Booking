
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

namespace SE
{
    public partial class C : Form
    {
       Cin obj1;
        Form1 obj2;
        public C()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // public string connectionString = "Data Source=DESKTOP-2QLMIOT;Initial Catalog=Train_Table;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCusLogID.Text != "" && textBoxCusLogPass.Text != "")
            {
                string connectionString = "Data Source=DESKTOP-2QLMIOT;Initial Catalog=Ttable;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);



                SqlCommand cmd = new SqlCommand("select *FROM Tuser_1 WHERE Uname = @id and Pass = @pass ", connection);



                connection.Open();
                cmd.Parameters.Add(new SqlParameter("id", textBoxCusLogID.Text));
                cmd.Parameters.Add(new SqlParameter("pass", textBoxCusLogPass.Text));



                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);



                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("LogIn successful !");
                    new Cin().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log in failed,doesn't match email or Password", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please insert your ID & Password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj2 = new Form1();
            obj2.Show();
        }
    }
}
