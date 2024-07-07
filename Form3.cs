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
    public partial class staff_right : Form
    {
        public staff_right()
        {
            InitializeComponent();
        }
        int q = 0;
        public int Drive(string time,string id,string sta)
        {
            dateTimePicker1.Text = time;
            textBox2.Text = id;
            textBox3.Text = sta;
            object ob = new object();
            EventArgs ev = new EventArgs();
            select_button_Click(ob, ev);
            return q;
        }
        DataTable dt = new DataTable();
        private void select_button_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(comboBox3.Text))
            //{
               /* MessageBox.Show("三个不可都为空！");
                return;*/
            //}
            //else
            //{
                if (string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    MessageBox.Show("未选择日期!");
                }
            string sctime = dateTimePicker1.Text; //+ " %" + comboBox1.Text + ":%" + comboBox2.Text + ":%" + comboBox3.Text + ".000";
                string name = textBox2.Text;
                string id = textBox3.Text;
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection sel_con = new SqlConnection(constr);
                if (string.IsNullOrEmpty(sctime))
                {
                    sctime = "";
                }
                if (string.IsNullOrEmpty(name))
                {
                    name = "";
                }
                if (!string.IsNullOrEmpty(id))
                {
                    try
                    {
                        
                        string sel = "select * from 扫描信息 where 扫描时间 like '" + sctime+"'and 商品名称 like '%"+name+"%' and 扫描人员编号="+id;
                        SqlDataAdapter ad = new SqlDataAdapter(sel, sel_con);
                        dt.Clear();
                    q = 1;  
                        ad.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                    //string sel = "select * from 扫描信息 where Convert(varchar,扫描时间,30) like '%" + sctime+"%'and 商品名称 like '%"+name+"%'";
                    //string sel = "select * from 扫描信息 where 扫描时间 like '" + sctime + "'and 商品名称 like '%" + name + "%'";
                    string sel = "select * from 扫描信息 where datediff(d,扫描时间,convert(datetime,'"+sctime+"',121))=0 ";

                    SqlDataAdapter ad = new SqlDataAdapter(sel, constr);
                        dt.Clear();
                        ad.Fill(dt);
                        //dataGridView1.Columns["扫描时间"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
                        dataGridView1.DataSource = dt;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
               // }
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staff_right_Load(object sender, EventArgs e)
        {
            string[] strhour = new string[] { "0","1", "2" , "3", "4", "5", "6" ,"7", "8", "9", "10", "11", "12" ,"13", "14" ,"15", "16", "17", "18" ,"19", "20" ,"21", "22" ,"23" };
            string[] strmin = new string[] { "0","1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"};
            string[] strsecond = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" };

            comboBox1.Items.AddRange(strhour);
            comboBox2.Items.AddRange(strmin);
            comboBox3.Items.AddRange(strsecond);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(e.KeyChar > '0' && e.KeyChar < '9'))
            {
                MessageBox.Show("输入只能是时间");
            }*/
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!(e.KeyChar > '0' && e.KeyChar < '9'))
            {
                MessageBox.Show("输入只能是");
            }*/
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')||e.KeyChar=='\b'))
            {
                MessageBox.Show("输入只能是数字");
                e.Handled = true;
            }
        }
    }
}
