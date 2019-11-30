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

            //--------------software cost estimation --------------------//
            string input = string.Empty;
            double timeline, probable_cost, effort, result;


            double.TryParse(textBox8.Text, out timeline);
            double.TryParse(textBox7.Text, out probable_cost);
            double.TryParse(textBox12.Text, out effort);

            result = probable_cost / (effort * timeline * 100);
            textBox13.Text = result.ToString();

            //--------------------Applying Bayes Theorem to validate ---------------------//
            //P(A|B) Posterior --validation based on the probability that user gave right requirements (specifications) and developer adhere to it
            // **
            //p(B|A) Likelihood -- validation based on the probability that developer complied given that the user gave right requirements
            //**
            //P(A) -- validation based on probability of the hypothesis without any prior information || user gave a requirement
            //**
            //P(B)  -- Validation based on probability by observing evidence from the likelihood || developer developed the system

            if (textBox4.Text == "" & textBox2.Text == "" & textBox9.Text == "")
            {

                string validation_report = string.Empty;

                validation_report = " POSTERIOR P(A|B) OR P(A) = Validation based on the probability that User gave right requirements (specifications) OR requirements on hypothesis without prior information  && LIKELIHOOD P(B|A) OR P(B)  Validation based on the probability that developer complied and developed OR development based on the probability of observing evidence from the likelihood";
                textBox14.Text = validation_report.ToString();
 
            }                  
        }

        private void Button3_Click(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO requirements (`client_name`, `app_name`, `user_spec`, `timeline`, `probable_cost`, `bus_area`,  `project_vision`, `prior_busprob`,  `dev_name`, `framework`, `resource_con`, `prog_lang`, `db`, `app_type`, `accessibility`, `availability`) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + textBox8.Text + "','" + textBox7.Text + "', '" + listBox1 + "', '" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox12.Text + "','" + textBox2.Text + "','" + textBox9.Text + "','" + textBox10.Text + "', '" + textBox11.Text + "', '" + listBox2 + "', '" + listBox3 + "', '" + listBox4 + "'  )", con);
            cmd.Parameters.Add("listBox1", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("listBox2", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("listBox3", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("listBox4", MySqlDbType.VarChar, 255);

            foreach (string item in listBox1.Items)
            {
                cmd.Parameters["listbox1"].Value = item;
                cmd.ExecuteNonQuery();

            }
            foreach (string item in listBox1.Items)
            {
                cmd.Parameters["listbox2"].Value = item;
                cmd.ExecuteNonQuery();

            }
            foreach (string item in listBox1.Items)
            {
                cmd.Parameters["listbox3"].Value = item;
                cmd.ExecuteNonQuery();

            }
            foreach (string item in listBox1.Items)
            {
                cmd.Parameters["listbox4"].Value = item;
                cmd.ExecuteNonQuery();

            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Requirements has been succesfully inserted in the database, click refresh button");
            con.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dashboard myform = new dashboard ();
            this.Hide();
            myform.Show();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If there's NaN as probable quality result then the validator is not receiving POSTERIOR P(A|B) OR P(A) && LIKELIHOOD P(B|A) OR P(B) , Please enter probable / assumed value in Numeric form inorder to get validation requirements report!");
            return;
        }
    }
}
