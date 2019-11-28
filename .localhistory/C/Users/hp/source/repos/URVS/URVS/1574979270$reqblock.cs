using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URVS
{
    public partial class Reqblock : Form
    {
        public Reqblock()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBoxIcon.Information.Equals ("try to");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("name can't be empty, please enter a value!");
                return;

            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("date can't be empty, please enter a value!");
                return;

            }

            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("application name can't be empty, please enter a value!");
                return;

            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox12.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox9.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox10.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            if (textBox11.Text == string.Empty)
            {
                MessageBox.Show("user's requirement can't be empty, please enter a value!");
                return;

            }
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=urvs");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO requirements (`tester`, `date`, `app_name`, `requirements`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("user story has been succesfully inserted in the database, click refresh button");
            con.Close();
        }
    }
}
