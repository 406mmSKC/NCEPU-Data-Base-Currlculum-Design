using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
            SqlConnection sel_con = new SqlConnection(constr);
            DataTable dt = new DataTable();
            string sel = "select 扫描人员编号,  count(*) as 数量 from 扫描信息 where 总价 > 20 group by 扫描人员编号";
            SqlDataAdapter ad = new SqlDataAdapter(sel, sel_con);
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
