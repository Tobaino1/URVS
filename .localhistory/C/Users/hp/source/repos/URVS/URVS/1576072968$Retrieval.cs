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
    public partial class Retrieval : Form
    {
        public Retrieval()
        {
            InitializeComponent();

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=urvs");
            con.Open();
            //MySqlDataAdapter sda = new MySqlDataAdapter("select * from reports ", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //foreach (DataRow item in dt.Rows)
            //{
            //    int n = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[n].Cells[0].Value = item["submit"].ToString();
            //    dataGridView1.Rows[n].Cells[1].Value = item["prob_qua_ass"].ToString();
            //    dataGridView1.Rows[n].Cells[2].Value = item["ass_val_rep"].ToString();
            //    dataGridView1.Rows[n].Cells[3].Value = item["curated_vo"].ToString();

               

                MySqlDataAdapter xda = new MySqlDataAdapter("select * from requirements ", con);
                DataTable xd = new DataTable();
                xda.Fill(xd);
                foreach (DataRow tem in xd.Rows)
                {
                    int m = dataGridView2.Rows.Add();
                    dataGridView2.Rows[m].Cells[0].Value = tem["submit"].ToString();
                    dataGridView2.Rows[m].Cells[1].Value = tem["client_name"].ToString();
                    dataGridView2.Rows[m].Cells[2].Value = tem["app_name"].ToString();
                    dataGridView2.Rows[m].Cells[3].Value = tem["user_spec"].ToString();
                    dataGridView2.Rows[m].Cells[4].Value = tem["likelihood"].ToString();
                    dataGridView2.Rows[m].Cells[5].Value = tem["p_a"].ToString();
                    dataGridView2.Rows[m].Cells[6].Value = tem["p_b"].ToString();


                //}
            }
        }

        private void Retrieval_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard myform = new dashboard();
            this.Hide();
            myform.Show();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
