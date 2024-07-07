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
    
    public partial class Form5 : Form
    {
       // public  string upkey;
        public Form5()
        {
            InitializeComponent();
        }
        int k = 0;
        public int Drivesc1(string time,string goodname,string sta,string to)
        {
            comboBox1.Text = "查询扫描信息";
            scantime_box1.Text = time;
            name_box1.Text = goodname;
            id_box2.Text = sta;
            total_box.Text = to;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);

            return k;
        }
        public int Drivesc2(string time,string time2, string goodname, string sta, string to)
        {
            comboBox1.Text = "查询扫描信息";
            radioButton1.Checked = true;
            scantime_box1.Text = time;
            scantime_box2.Text = time2;
            name_box1.Text = goodname;
            id_box2.Text = sta;
            total_box.Text = to;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);

            return k;
        }
        public int Drivegood(string id,string name,string sto,bool sal)
        {
            comboBox1.Text = "查询商品信息";
            id_box3.Text = id;
            name_box2.Text = name;
            singlemoney_box.Text=sto;
            radioButton2.Checked = sal;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return k;
        }
        public int Drivesta(string id, string name, string sex,string lev)
        {
            comboBox1.Text = "查询职工信息";
            id_box4.Text = id;
            name_box3.Text = name;
            sex_box.Text = sex;
            job_box.Text = lev;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return k;
        }
        public int Driveacc(string username, string right)
        {
            comboBox1.Text = "查询注册信息";
            username_box.Text = username;
            right_box.Text = right;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return k;
        }
        public int Drivedel()
        {
            object ob = new object();
            EventArgs ev = new EventArgs();
            删除ToolStripMenuItem_Click(ob, ev);
            return k;
        }
        public int Driveup()
        {
            object ob = new object();
            EventArgs ev = new EventArgs();
            修改ToolStripMenuItem_Click(ob, ev);
            return k;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            string[] str = new string[] { "查询扫描信息", "查询商品信息","查询职工信息","查询注册信息" };
            comboBox1.Items.AddRange(str);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
               
                MessageBox.Show("未选择所查询表");
                return;
            }
            string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
            SqlConnection sel_con = new SqlConnection(constr);
            DataTable dt = new DataTable();
            try
            {
                if (comboBox1.Text == "查询注册信息")
                {
                    
                    string user_name = username_box.Text;
                    string right = right_box.Text;
                    if (string.IsNullOrEmpty(user_name) && string.IsNullOrEmpty(right)){
                        MessageBox.Show("查询信息不可全为空");
                        return;
                    }//最好在此处将两项中空的一项转换为""
                    string sel_reg = "select ID,JOB from 账户 where ID like '%" + user_name + "%' and JOB like '%" + right + "%'";
                    SqlDataAdapter sqlda = new SqlDataAdapter(sel_reg, sel_con);
                    dt.Clear();
                    sqlda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    k = 1;
                    return;
                }
                if (comboBox1.Text == "查询商品信息")
                {
                    string goods_id = id_box3.Text;
                    string goods_name = name_box2.Text;
                    string store = singlemoney_box.Text;//这里做了修改，把单价框变成库存了，
                    if (string.IsNullOrEmpty(goods_id) && string.IsNullOrEmpty(goods_name) && string.IsNullOrEmpty(store))
                    {
                        MessageBox.Show("查询信息不可全为空");
                        return;
                    }
                    if (!string.IsNullOrEmpty(goods_name)&&string.IsNullOrEmpty(store)&&string.IsNullOrEmpty(goods_id))
                    {
                        string sel_goods = "select * from  商品信息 where 商品名称 like '%" + goods_name + "%' and 是否打折='" + radioButton2.Checked + "'";
                        SqlDataAdapter sqlda = new SqlDataAdapter(sel_goods, sel_con);
                        dt.Clear();
                        sqlda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        k = 1;
                        return;
                    }

                    if (string.IsNullOrEmpty(goods_name) && !string.IsNullOrEmpty(store) && string.IsNullOrEmpty(goods_id))
                    {
                        string sel_goods = "select * from  商品信息 where 库存 <='" + store + "' and 是否打折='" + radioButton2.Checked + "'";
                        SqlDataAdapter sqlda = new SqlDataAdapter(sel_goods, sel_con);
                        dt.Clear();
                        sqlda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        k = 1;
                        return;
                    }
                    if (!string.IsNullOrEmpty(goods_name) && !string.IsNullOrEmpty(store) && !string.IsNullOrEmpty(goods_id))
                    {
                        string sel_goods = "select * from  商品信息 where 库存 <='" + store + "' and 是否打折='" + radioButton2.Checked + "'and "+"商品编号 ='"+goods_id+"' and 商品名称='"+goods_name+"'";
                        SqlDataAdapter sqlda = new SqlDataAdapter(sel_goods, sel_con);
                        dt.Clear();
                        sqlda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        k = 1;
                        return;
                    }

                    if (string.IsNullOrEmpty(goods_name) && string.IsNullOrEmpty(store) && !string.IsNullOrEmpty(goods_id))
                    {
                        string sel_goods = "select * from  商品信息 where 商品编号= '" + goods_id + "' and 是否打折='" + radioButton2.Checked + "'";
                        SqlDataAdapter sqlda = new SqlDataAdapter(sel_goods, sel_con);
                        dt.Clear();
                        sqlda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        k = 1;
                        return;
                    }
                    //MessageBox.Show("只能填一项");
                    
                }
                if (comboBox1.Text == "查询职工信息")
                {

                    string  staff_id= id_box4.Text;
                    string staff_name = name_box3.Text;
                    string sex = sex_box.Text;
                    string staff_job = job_box.Text;
                    string sel_staff = "";
                    if (string.IsNullOrEmpty(staff_id) && string.IsNullOrEmpty(staff_name)&&string.IsNullOrEmpty(sex)&&string.IsNullOrEmpty(staff_job))
                    {
                        MessageBox.Show("查询信息不可全为空");
                        return;
                    }

                    if (string.IsNullOrEmpty(staff_id))
                    {
                        
                         sel_staff = "select * from 职员信息 where 姓名 like '%" + staff_name + "%' and 性别 like '%" + sex + "%' and 职位 like '%" + staff_job + "%'"+"and 在职 = 'True'";
                    }
                    else
                    {
                        
                         sel_staff = "select * from 职员信息 where 编号 like '%" + staff_id + "%' and 姓名 like '%" + staff_name + "%' and 性别 like '%" + sex + "%' and 职位 like '%" + staff_job + "%'" + "and 在职 = 'True'";
                    }
                    SqlDataAdapter sqlda = new SqlDataAdapter(sel_staff, sel_con);
                    dt.Clear();
                    sqlda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    k = 1;
                    return;
                }
                if (comboBox1.Text == "查询扫描信息")
                {

                    string scantime1 = scantime_box1.Text;
                    string scantime2 = scantime_box2.Text;
                    string goods_name = name_box1.Text;
                    string sc_id = id_box2.Text;
                    string total_money = total_box.Text;
                    string sel_scan = "";
                    if (string.IsNullOrEmpty(scantime1) && string.IsNullOrEmpty(scantime2)&&string.IsNullOrEmpty(goods_name)&&string.IsNullOrEmpty(total_money))
                    {
                        MessageBox.Show("查询信息不可全为空");
                        return;
                    }//最好在此处将两项中空的一项转换为""
                    if (radioButton1.Checked == true)
                    {
                        if (string.IsNullOrEmpty(total_money))
                        {
                            if (string.IsNullOrEmpty(sc_id))
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 >= '" + scantime1 + "' and 扫描时间 <= '" + scantime2 + "' and 商品名称 like '%" + goods_name + "%'";
                            }
                            else
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 >= '" + scantime1 + "' and 扫描时间 <= '" + scantime2 + "' and 商品名称 like '%" + goods_name + "%' and 扫描人员编号 = '" + sc_id + "'";

                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(sc_id))
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 >= '" + scantime1 + "' and 扫描时间 <= '" + scantime2 + "' and 商品名称 like '%" + goods_name + "%'and 总价 >= '" + total_money + "'";

                            }
                            else
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 >= '" + scantime1 + "' and 扫描时间 <= '" + scantime2 + "' and 商品名称 like '%" + goods_name + "%'and 总价 >= '" + total_money + "'and 扫描人员编号 ='"+sc_id+"'";

                            }
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(total_money))
                        {
                            if (string.IsNullOrEmpty(sc_id))
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 like '%" + scantime1 + "%' and 商品名称 like '%" + goods_name + "%'";
                            }
                            else
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 like '%" + scantime1 + "%' and 商品名称 like '%" + goods_name + "%' and 扫描人员编号 = '"+sc_id+"'";

                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(sc_id))
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 like '%" + scantime1 + "%' and 商品名称 like '%" + goods_name + "%'and 总价 >= '" + total_money + "'";
                            }
                            else
                            {
                                sel_scan = "select * from 扫描信息 where 扫描时间 like '%" + scantime1 + "%' and 商品名称 like '%" + goods_name + "%'and 总价 >= '" + total_money + "'and 扫描人员编号 = '"+sc_id+"'";

                            }
                        }
                    }
                    SqlDataAdapter sqlda = new SqlDataAdapter(sel_scan, sel_con);
                    dt.Clear();
                    sqlda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (comboBox1.Text == "查询扫描信息")
                    {
                       dataGridView1.Columns["扫描时间"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
                    }
                    k = 1;
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("输入不合法!");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        bool ra2_check = false;
        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (ra2_check)
            {
                radioButton2.Checked = false;
                ra2_check= false;
            }
            else
            {
                radioButton2.Checked = true;
                ra2_check = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string del_index;
            string sql_del="" ;
            if (dataGridView1.CurrentRow!=null)
            {
               // MessageBox.Show("进入删除");
                del_index = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (comboBox1.Text == "查询扫描信息")
                {
                   // dataGridView1.CurrentRow
                    sql_del = "delete from 扫描信息 where 扫描时间 = '" + del_index + "'";
                }
                if (comboBox1.Text == "查询职工信息")
                {
                    sql_del = "update 职员信息 set 在职 = 'False' where 编号='" + del_index + "'";
                }
                if (comboBox1.Text == "查询注册信息")
                {
                    sql_del = "delete from 账户 where ID='" + del_index + "'";
                }
                if (comboBox1.Text == "查询商品信息")
                {
                    sql_del = "delete from 商品信息 where 商品编号='" + del_index + "'";
                }

            }
            else
            {
               
               MessageBox.Show("没有进入删除");
                return;
            }
            string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
            SqlConnection del_con = new SqlConnection(constr);
            del_con.Open();
            /*DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(, del_con);
            dt.Clear();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
            return;*/
            SqlCommand sqlcom = new SqlCommand(sql_del, del_con);
            int k=sqlcom.ExecuteNonQuery();
            if (k > 0)
            {
                k = 1;
                MessageBox.Show("成功删除了"+k.ToString()+"行");
            }
            else
            {
                MessageBox.Show("此行已被删除，请重新查询刷新");
            }
            del_con.Close();
        }
        bool ra1_check = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (ra1_check)
                {
                    radioButton1.Checked = false;
                    ra1_check = false;
                    scantime_box2.Text = "";
                    scantime_box2.ReadOnly = true;
                }
            else
                {
                    radioButton1.Checked = true;
                    ra1_check = true;
                scantime_box2.ReadOnly = false;
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string sql_del = "";
            if (dataGridView1.CurrentRow != null)
            {
                // MessageBox.Show("进入删除");
                string upkey = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string tranid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string tranname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string transin = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string tranmass = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string tranto = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string transta = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                /*if (comboBox1.Text == "查询扫描信息")
                {
                    
                    // dataGridView1.CurrentRow
                    //sql_del = "delete from 扫描信息 where 扫描时间 = '" + del_index + "'";
                }
                if (comboBox1.Text == "查询职工信息")
                {
                    //sql_del = "update 职员信息 set 在职 = 'False' where 编号='" + del_index + "'";
                }
                if (comboBox1.Text == "查询注册信息")
                {
                    //sql_del = "delete from 账户 where ID='" + del_index + "'";
                }
                if (comboBox1.Text == "查询商品信息")
                {
                    //sql_del = "delete from 商品信息 where 商品编号='" + del_index + "'";
                }
                */
                k = 1;
                Form7 up_page_ = new Form7(upkey,tranid,tranname,transin,tranmass,tranto,transta);
                up_page_.ShowDialog();
            }
            else
            {

                MessageBox.Show("没有进入修改");
                return;
            }
            
        }
    }
}
