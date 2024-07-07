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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int w = 0;
        public int Drivesc(string addtable,string year,string month,string day,string hour,string minute,string second,string goodid,string goodname,string sin,string mass,string tot,string sta)
        {
            comboBox1.Text = addtable;
            year_box.Text = year;
            month_box.Text = month;
            day_box.Text = day;
            hour_box.Text = hour;
            min_box.Text = minute;
            second_box.Text = second;
            scid_box.Text = goodid;
            scname_box.Text = goodname;
            scsin_box.Text = sin;
            mass_box.Text = mass;
            total_box.Text = tot;
            scanid_box.Text = sta;
            object ob=new object();
            EventArgs ev = new EventArgs();
            button2_Click(ob, ev);
            return w;
        }
        public int Drivego(string addtable,string id,string name,string sin,string sto,bool sal)
        {
            comboBox1.Text = addtable;
            goods_id.Text = id;
            goods_name.Text = name;
            goods_sin.Text = sin;
            goods_store.Text = sto;
            ifdiscount.Checked = sal;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button2_Click(ob, ev);
            return w;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("选择添加的表");
                return;
            }
            if (comboBox1.Text == "添加扫描信息")
            {
                string addyear = year_box.Text;
                string addmonth = month_box.Text;
                string addday = day_box.Text;
                string addhour = hour_box.Text;
                string addmin = min_box.Text;
                string addsecond = second_box.Text;
                string addexsecond = exsecond_box.Text;
                string addscid = scid_box.Text;
                string addname = scname_box.Text;
                string addsin = scsin_box.Text;
                string addtotal = total_box.Text;
                string addscstaffid = scanid_box.Text;
                string addmass = mass_box.Text;
                if (string.IsNullOrEmpty(addyear) || string.IsNullOrEmpty(addscid) || string.IsNullOrEmpty(addname) || string.IsNullOrEmpty(addsin) || string.IsNullOrEmpty(addtotal) || string.IsNullOrEmpty(addscstaffid) || string.IsNullOrEmpty(addmonth) || string.IsNullOrEmpty(addday) || string.IsNullOrEmpty(addhour) || string.IsNullOrEmpty(addmin) || string.IsNullOrEmpty(addsecond) || string.IsNullOrEmpty(addexsecond))
                {
                    MessageBox.Show("不可有空缺！");
                    return;
                }
                float temp;
                bool flag = float.TryParse(addsin, out temp);
                if (!flag)
                {
                    MessageBox.Show("输入的单价不是钱数");
                    return;
                }
                flag = float.TryParse(addmass, out temp);
                if (!flag)
                {
                    MessageBox.Show("输入的质量不是合法数字");
                    return;
                }
                flag = float.TryParse(addtotal, out temp);
                if (!flag)
                {
                    MessageBox.Show("输入的总价不是合法数字");
                    return;
                }
                int tempt, year_;
                flag = int.TryParse(addyear, out year_);
                if (!flag)
                {
                    MessageBox.Show("输入的年不是合法数字");
                    return;
                }
                if (year_ > 2025 || year_ < 2000)
                {
                    MessageBox.Show("检查年份!");
                    return;
                }
                int month_;
                flag = int.TryParse(addmonth, out month_);
                if (!flag)
                {
                    MessageBox.Show("输入的月不是合法数字");
                    return;
                }
                if (month_ < 1 || month_ > 12)
                {
                    MessageBox.Show("检查月份!");
                    return;
                }
                int day_;
                flag = int.TryParse(addday, out day_);
                if (!flag)
                {
                    MessageBox.Show("输入的日不是合法数字");
                    return;
                }
                if (day_ > 31 || day_ < 1)
                {
                    MessageBox.Show("检查输入的日期!");
                    return;
                }
                if (month_ == 2 || month_ == 4 || month_ == 6 || month_ == 9 || month_ == 11)
                {
                    if (day_ == 31)
                    {
                        MessageBox.Show("这个月真的有31天吗?");
                        return;
                    }
                }
                if (month_ == 2)
                {
                    if (year_ == 2000 || year_ == 2004 || year_ == 2008 || year_ == 2012 || year_ == 2016 || year_ == 2020 || year_ == 2024)
                    {
                        if (day_ > 29)
                        {
                            MessageBox.Show("检查输入的日期！");
                            return;
                        }
                    }
                    else
                    {
                        if (day_ > 28)
                        {
                            MessageBox.Show("检查输入的日期!");
                            return;
                        }
                    }
                }
                flag = int.TryParse(addhour, out tempt);
                if (!flag)
                {
                    MessageBox.Show("输入的小时不是合法数字");
                    return;
                }
                if (tempt > 59 || tempt < 0)
                {
                    MessageBox.Show("检查输入的小时");
                    return;
                }
                flag = int.TryParse(addmin, out tempt);
                if (!flag)
                {
                    MessageBox.Show("输入的分不是合法数字");
                    return;
                }
                if (tempt > 59 || tempt < 0)
                {
                    MessageBox.Show("检查输入的分");
                    return;
                }
                flag = int.TryParse(addsecond, out tempt);
                if (!flag)
                {
                    MessageBox.Show("输入的秒不是合法数字");
                    return;
                }
                if (tempt > 59 || tempt < 0)
                {
                    MessageBox.Show("检查输入的秒");
                    return;
                }
                flag = int.TryParse(addexsecond, out tempt);
                if (!flag)
                {
                    MessageBox.Show("输入的秒后小数点不是合法数字");
                    return;
                }
                if (tempt > 999 || tempt < 0)
                {
                    MessageBox.Show("输入的小数点后数字不正确");
                    return;
                }
                string sctimestr = addyear + "-" + addmonth + "-" + addday + " " + addhour + ":" + addmin + ":" + addsecond + "." + addexsecond;
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection insert_con = new SqlConnection(constr);
                insert_con.Open();
                string sel_str = "select * from 扫描信息 where 扫描时间 ='" + sctimestr + "'";
                string insert_str = "insert into 扫描信息 VALUES ('" + sctimestr + "','" + addscid + "','" + addname + "','" + addsin + "','" + addmass + "','" + addtotal + "','" + addscstaffid + "')";
                SqlCommand sel_com = new SqlCommand(sel_str, insert_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    MessageBox.Show("该时间已存在扫描信息!");
                    insert_con.Close();
                    return;
                }
                insert_con.Close();
                insert_con.Open();
                string sel_goods_str = "select * from 商品信息 where 商品编号 ='" + addscid + "' and 商品名称= '"+addname+"'";
                SqlCommand sel_goods_com = new SqlCommand(sel_goods_str, insert_con);
                SqlDataReader dr_goods_sel = sel_goods_com.ExecuteReader();
                if (!dr_goods_sel.HasRows)
                {
                    MessageBox.Show("无此商品!");
                    insert_con.Close();
                    return;
                }
                insert_con.Close();
                insert_con.Open();

                SqlCommand insert_com = new SqlCommand(insert_str, insert_con);
                int num = insert_com.ExecuteNonQuery();
                insert_con.Close();
                w = 1;
                MessageBox.Show(num + "条信息已插入");
            }
            if (comboBox1.Text == "添加商品信息")
            {
                string addid = goods_id.Text;
                string addname = goods_name.Text;
                string addsin = goods_sin.Text;
                string addstore = goods_store.Text;
                string adddiscount = ifdiscount.Checked.ToString();
                if (string.IsNullOrEmpty(addid) || string.IsNullOrEmpty(addsin) || string.IsNullOrEmpty(addname) || string.IsNullOrEmpty(addstore))
                {
                    MessageBox.Show("未填写全信息！");
                    return;
                }
                float temp;
                bool flag1 = float.TryParse(addsin, out temp);
                bool flag2 = float.TryParse(addstore, out temp);
                if (!flag1 || !flag2)
                {
                    MessageBox.Show("输入的单价和库存不是合法数字");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection insert_con = new SqlConnection(constr);
                insert_con.Open();
                string sel_str = "select * from 商品信息 where 商品编号 ='" + addid + "'";
                string insert_str = "insert into 商品信息 VALUES ('" + addid + "','" + addname + "','" + addsin + "','" + addstore + "','" + adddiscount + "')";
                SqlCommand sel_com = new SqlCommand(sel_str, insert_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    MessageBox.Show("该编号商品已存在!");
                    insert_con.Close();
                    return;
                }
                insert_con.Close();
                insert_con.Open();
                SqlCommand insert_com = new SqlCommand(insert_str, insert_con);
                int num = insert_com.ExecuteNonQuery();
                insert_con.Close();
                w = 1;
                MessageBox.Show(num + "条信息已插入");
            }
            if (comboBox1.Text == "添加职工信息")
            {
                string addid = staid.Text;
                string addname = staname.Text;
                string addsex = stasex.Text;
                string addjob = stajob.Text;
                string addsal = stasal.Text;
                if (string.IsNullOrEmpty(addid) || string.IsNullOrEmpty(addname) || string.IsNullOrEmpty(addsex) || string.IsNullOrEmpty(addsal) || string.IsNullOrEmpty(addjob))
                {
                    MessageBox.Show("不得有空！");
                    return;
                }
                if (addsex != "男" && addsex != "女")
                {
                    MessageBox.Show("本店只招聘正常人类");
                    return;
                }
                float temp;
                bool flag = float.TryParse(addsal, out temp);
                if (!flag)
                {
                    MessageBox.Show("输入的工资不是合法数字");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection insert_con = new SqlConnection(constr);
                insert_con.Open();
                string sel_str = "select * from 职员信息 where 编号 ='" + addid + "'";
                string insert_str = "insert into 职员信息 VALUES ('" + addid + "','" + addname + "','" + addsex + "','" + addjob + "','" + addsal + "','True')";
                SqlCommand sel_com = new SqlCommand(sel_str, insert_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    MessageBox.Show("该编号人员已存在/存在过!");
                    insert_con.Close();
                    return;
                }
                insert_con.Close();
                insert_con.Open();
                SqlCommand insert_com = new SqlCommand(insert_str, insert_con);
                int num = insert_com.ExecuteNonQuery();
                insert_con.Close();
                MessageBox.Show(num + "条信息已插入");
            }
            if (comboBox1.Text == "添加注册信息")
            {
                string adduser = user_box.Text;
                string addpass = pass_box.Text;
                string addright = right_box.Text;
                if (string.IsNullOrEmpty(adduser) || string.IsNullOrEmpty(addpass) || string.IsNullOrEmpty(addright))
                {
                    MessageBox.Show("输入不得有空");
                    return;
                }
                if (addright != "经理" && addright != "员工")
                {
                    MessageBox.Show("权限只有经理或员工");
                    return;
                }
                if (adduser.Length < 5 || adduser.Length > 20 || addpass.Length < 5 || addpass.Length > 20)
                {
                    MessageBox.Show("账户和密码应当在5到20位之间");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection insert_con = new SqlConnection(constr);
                insert_con.Open();
                string sel_str = "select * from 账户 where ID ='" + adduser + "'";
                string insert_str = "insert into 账户 VALUES ('" + adduser + "','" + addpass + "','" + addright + "')";
                SqlCommand sel_com = new SqlCommand(sel_str, insert_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    MessageBox.Show("用户名存在重复!");
                    insert_con.Close();
                    return;
                }
                insert_con.Close();
                insert_con.Open();
                SqlCommand insert_com = new SqlCommand(insert_str, insert_con);
                int num = insert_com.ExecuteNonQuery();
                insert_con.Close();
                MessageBox.Show(num + "条信息已插入");
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] str = new string[] { "添加扫描信息", "添加商品信息" };
            comboBox1.Items.AddRange(str);

        }

        private void scid_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                scid_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void scanid_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                scanid_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void year_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                year_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void month_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                month_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void day_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                day_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void hour_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                hour_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void min_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                min_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void second_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                second_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void exsecond_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                exsecond_box.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void goods_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                goods_id.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
            }
        }

        private void staid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\b')
            {
                staid.Text = "";
                MessageBox.Show("输入只能为数字");
                e.Handled = true;
                return;
            }
        }

        private void stasex_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void user_box_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        bool discount_check = false;

        private void ifdiscount_CheckedChanged(object sender, EventArgs e)
        {
            /*if (discount_check)
            {
                ifdiscount.Checked = false;
                discount_check = false;
            }
            else
            {
                ifdiscount.Checked = true;
                discount_check = true;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exsecond_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void ifdiscount_Click(object sender, EventArgs e)
        {
            if (discount_check)
            {
                ifdiscount.Checked = false;
                discount_check = false;
            }
            else
            {
                ifdiscount.Checked = true;
                discount_check = true;
            }
        }
    }
}
