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
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from reports ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["submit"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["prob_qua_ass"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["ass_val_rep"].ToString();
                //dataGridView1.Rows[n].Cells[3].Value = item["id"].ToString();

            }
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=urvs");
            //conn.Open();
            MySqlDataAdapter xda = new MySqlDataAdapter("select * from requirements ", conn);
            DataTable xd = new DataTable();
            xda.Fill(xd);
            foreach (DataRow item in xd.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["submit"].ToString();
                //dataGridView2.Rows[n].Cells[1].Value = item["client_name"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["app_name"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["user_spec"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["timeline"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["probable_cost"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item["bus_area"].ToString();
                dataGridView2.Rows[n].Cells[7].Value = item["project_vision"].ToString();
                dataGridView2.Rows[n].Cells[8].Value = item["prior_busprob"].ToString();
                dataGridView2.Rows[n].Cells[9].Value = item["dev_name"].ToString();
                dataGridView2.Rows[n].Cells[10].Value = item["framework"].ToString();
                dataGridView2.Rows[n].Cells[11].Value = item["resource_con"].ToString();
                dataGridView2.Rows[n].Cells[12].Value = item["prog_lang"].ToString();
                dataGridView2.Rows[n].Cells[13].Value = item["db"].ToString();
                dataGridView2.Rows[n].Cells[14].Value = item["app_type"].ToString();
                dataGridView2.Rows[n].Cells[15].Value = item["accessibility"].ToString();
                dataGridView2.Rows[n].Cells[16].Value = item["availability"].ToString();
                //dataGridView2.Rows[n].Cells[17].Value = item["id"].ToString();

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
    }
}
