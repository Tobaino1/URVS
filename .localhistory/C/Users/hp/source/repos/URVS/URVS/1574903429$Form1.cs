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


namespace URVS
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=urvs");
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Username field can't be empty, please enter a value");
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Password field can't be empty, please enter a value");
                return;
            }

            i = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from user WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)

            {
                MessageBox.Show("Wrong user login details, please try again!");
            }
            else
            {
                MessageBox.Show("Correct User Login details!");
                dashboard myform = new dashboard();
                this.Hide();
                myform.Show();
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
