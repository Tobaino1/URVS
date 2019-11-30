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
  
            }
        }

        private void Retrieval_Load(object sender, EventArgs e)
        {

        }
    }
}
