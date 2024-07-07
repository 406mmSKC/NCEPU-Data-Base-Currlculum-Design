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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int y = 0;
        public int Drivesc(string addtable, string year1, string month1, string day1, string hour1, string minute1, string second1, string goodid, string goodname, string sin, string mass1, string tot, string sta)
        {
            comboBox1.Text = addtable;
            year.Text = year1;
            month.Text = month1;
            day.Text = day1;
            hour.Text = hour1;
            minute.Text = minute1;
            second.Text = second1;
            scgoodsid.Text = goodid;
            scname.Text = goodname;
            scsin.Text = sin;
            mass.Text = mass1;
            total.Text = tot;
            scstaid.Text = sta;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return y;
        }
        public int Drivego(string addtable, string id, string name, string sin1, string sto, string sal)
        {
            comboBox1.Text = addtable;
            goodsid.Text = id;
            goodsname.Text = name;
            sin.Text = sin1;
            store.Text = sto;
            ifdiscount.Text= sal;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return y;
        }
        public int Drivejob(string addtable, string id, string name, string sex1, string job1,string mon)
        {
            comboBox1.Text = addtable;
            staid.Text = id;
            staname.Text = name;
            sex.Text = sex1;
            job.Text = job1;
            salary.Text = mon;
            object ob = new object();
            EventArgs ev = new EventArgs();
            button1_Click(ob, ev);
            return y;
        }
        public Form7(string upkey,string tranid,string tranname,string transin,string tranmass,string tranto,string transta)
        {
            InitializeComponent();
            transkey.Text = upkey;
            scgoodsid.Text= tranid;
            scname.Text = tranname;
            scsin.Text = transin;
            mass.Text = tranmass;
            total.Text = tranto;
            scstaid.Text = transta;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //transkey.Text=Form5.
            string[] str1 = new string[] { "修改扫描信息", "修改商品信息", "修改职工信息"};
            string[] str2 = new string[] { "True","False"};
            string[] str3 = new string[] { "男","女" };
            string[] str4 = new string[] { "经理","员工" };
            comboBox1.Items.AddRange(str1);
            ifdiscount.Items.AddRange(str2);
            sex.Items.AddRange(str3);
            right.Items.AddRange(str4);
            if (transkey.Text != "无传入参数(本文本为验收时要求新加的功能)")
            {
                year.Text = "0";
                month.Text = "0";
                day.Text = "0";
                hour.Text = "00";
                minute.Text = "00";
                second.Text = "0";
                /*year.ReadOnly = true;
                month.ReadOnly = true;
                day.ReadOnly = true;
                hour.ReadOnly = true;
                minute.ReadOnly = true;
                second.ReadOnly = true;*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("选择修改的表");
                return;
            }
            if (comboBox1.Text == "修改扫描信息")
            {
                string upyear = year.Text;
                string upmonth = month.Text;
                string upday = day.Text;
                string uphour = hour.Text;
                string upmin = minute.Text;
                string upsecond = second.Text;
                string upexsecond = exsecond.Text;
                string upid = scgoodsid.Text;
                string upname = scname.Text;
                string upsin = scsin.Text;
                string upmass = mass.Text;
                string uptotal = total.Text;
                string upstaid = scstaid.Text;
                
                if (string.IsNullOrEmpty(upyear) || string.IsNullOrEmpty(upmonth) || string.IsNullOrEmpty(upday) || string.IsNullOrEmpty(uphour) || string.IsNullOrEmpty(upmin) || string.IsNullOrEmpty(upsecond) || string.IsNullOrEmpty(upexsecond) || string.IsNullOrEmpty(upstaid) || string.IsNullOrEmpty(upname) || string.IsNullOrEmpty(upid) || string.IsNullOrEmpty(upsin) || string.IsNullOrEmpty(upmass) || string.IsNullOrEmpty(uptotal))
                {
                    MessageBox.Show("信息不得有空");
                    return;
                }
                bool flag1,flag2,flag3,flag4,flag5,flag6,flag7,flag8,flag9,flag10,flag11,flag12;
                float temp;
                int tempt,year_,month_,day_;
                flag1 = int.TryParse(upyear, out year_);
                
                
                flag2 = int.TryParse(upmonth, out month_);
                flag3 = int.TryParse(upday, out day_);
                flag4 = int.TryParse(uphour, out tempt);
                flag5 = int.TryParse(upmin, out tempt);
                flag6 = int.TryParse(upsecond, out tempt);
                flag7 = int.TryParse(upexsecond, out tempt);
                flag8 = float.TryParse(upid, out temp);
                flag9 = float.TryParse(upsin, out temp);
                flag10 = float.TryParse(upmass, out temp);
                flag11 = float.TryParse(uptotal, out temp);
                flag12 = float.TryParse(upstaid, out temp);
                if(!flag1|| !flag2 || !flag3 || !flag4 || !flag5 || !flag6 || !flag7 || !flag8 || !flag9 || !flag10 || !flag11 || !flag12)
                {
                    MessageBox.Show("输入的数据不合法!");
                    return;
                }
                if (year_ > 2024 || year_ < 2000)
                {
                    MessageBox.Show("输入年份不合法");
                    return;
                }
                if (month_ < 1 || month_ > 12)
                {
                    MessageBox.Show("检查月份!");
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
                string time="'"+upyear+"-"+upmonth+"-"+upday+" "+uphour+":"+upmin+":"+upsecond+"."+upexsecond+"'";
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection up_con = new SqlConnection(constr);

                if (transkey.Text != "无传入参数(本文本为验收时要求新加的功能)")
                {
                    time = transkey.Text + ".000";

                    //string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                    SqlConnection insert_con = new SqlConnection(constr);
                    insert_con.Open();
                    string sel_goods_str = "select * from 商品信息 where 商品编号 ='" + upid + "'and 商品名称 ='"+upname+"'";
                    SqlCommand sel_goods_com = new SqlCommand(sel_goods_str, insert_con);
                    SqlDataReader dr_goods_sel = sel_goods_com.ExecuteReader();
                    if (!dr_goods_sel.HasRows)
                    {
                        MessageBox.Show("无此商品!");
                        insert_con.Close();
                        return;
                    }
                    insert_con.Close();
                   // insert_con.Open();

                    //string sel_str = "select * from 扫描信息 where 扫描时间 ="+time;
                    string up_str = "update 扫描信息  set 商品编号 = '" + upid + "' ,商品名称 = '" + upname + "' ,商品单价 = '" + upsin + "' ,质量 = '" + upmass + "' ,总价 = '" + uptotal + "' ,扫描人员编号 = '" + upstaid + "' where 扫描时间 = "+ time+"";
                    //SqlCommand sel_com = new SqlCommand(sel_str, up_con);
                    //SqlDataReader dr_sel = sel_com.ExecuteReader();


                    up_con.Open();
                    SqlCommand up_com = new SqlCommand(up_str, up_con);
                    int num = up_com.ExecuteNonQuery();
                    y = 1;
                    MessageBox.Show(num + "条信息被修改");
                    if (num == 0)
                    {
                        MessageBox.Show("检查是否有这条信息吗");
                    }
                    return;
                }
                else
                {
                    SqlConnection insert_con = new SqlConnection(constr);
                    insert_con.Open();
                    string sel_goods_str = "select * from 商品信息 where 商品编号 ='" + upid + "'and 商品名称 ='" + upname + "'";
                    SqlCommand sel_goods_com = new SqlCommand(sel_goods_str, insert_con);
                    SqlDataReader dr_goods_sel = sel_goods_com.ExecuteReader();
                    if (!dr_goods_sel.HasRows)
                    {
                        MessageBox.Show("无此商品!");
                        insert_con.Close();
                        return;
                    }
                    insert_con.Close();
                    // insert_con.Open();

                    //string sel_str = "select * from 扫描信息 where 扫描时间 ="+time;
                    string up_str = "update 扫描信息  set 商品编号 = '" + upid + "' ,商品名称 = '" + upname + "' ,商品单价 = '" + upsin + "' ,质量 = '" + upmass + "' ,总价 = '" + uptotal + "' ,扫描人员编号 = '" + upstaid + "' where 扫描时间 = " + time + "";
                    //SqlCommand sel_com = new SqlCommand(sel_str, up_con);
                    //SqlDataReader dr_sel = sel_com.ExecuteReader();


                    up_con.Open();
                    SqlCommand up_com = new SqlCommand(up_str, up_con);
                    int num = up_com.ExecuteNonQuery();
                    y = 1;
                    MessageBox.Show(num + "条信息被修改");
                    if (num == 0)
                    {
                        MessageBox.Show("检查是否有这条信息吗");
                    }
                    return;
                }
            }
            if (comboBox1.Text == "修改商品信息")
            {
                string upid = goodsid.Text;
                string upname = goodsname.Text;
                string upsin = sin.Text;
                string upstore = store.Text;
                string updiscount = ifdiscount.Text;
                if (string.IsNullOrEmpty(upid) || string.IsNullOrEmpty(upname) || string.IsNullOrEmpty(upsin) || string.IsNullOrEmpty(upstore) || string.IsNullOrEmpty(updiscount))
                {
                    MessageBox.Show("信息不能有空！");
                    return;
                }
                bool flag1, flag2, flag3;
                float temp;
                flag1 = float.TryParse(upsin, out temp);
                flag2 = float.TryParse(upid, out temp);
                flag3 = float.TryParse(upstore, out temp);
                if (!flag1 || !flag2 || !flag3)
                {
                    MessageBox.Show("输入数字不合法");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
                SqlConnection up_con = new SqlConnection(constr);
                up_con.Open();
                string sel_str = "select * from 商品信息 where 商品编号 = '" + upid+"'";
                string up_str = "update 商品信息  set 商品名称 = '" + upname + "' ,单价 = '" + upsin + "' ,库存 = '" + upstore + "' ,是否打折 = '" + updiscount + "' where 商品编号 = '" + upid + "'";
                SqlCommand sel_com = new SqlCommand(sel_str, up_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    up_con.Close();
                    up_con.Open();
                    SqlCommand up_com = new SqlCommand(up_str, up_con);
                    int num = up_com.ExecuteNonQuery();
                    y = 1;
                    MessageBox.Show(num + "条信息被修改");
                    return;
                }
                else
                {
                    MessageBox.Show("没有这条信息");
                    return;
                }
            }
            if (comboBox1.Text == "修改职工信息")
            {
                string upid = staid.Text;
                string upname = staname.Text;
                string upsex = sex.Text;
                string upjob = job.Text;
                string upsal = salary.Text;
                if (string.IsNullOrEmpty(upid) || string.IsNullOrEmpty(upname) || string.IsNullOrEmpty(upsex) || string.IsNullOrEmpty(upjob) || string.IsNullOrEmpty(upsal))
                {
                    MessageBox.Show("信息不能有空！");
                    return;
                }
                bool flag1, flag2;
                float temp;
                flag1 = float.TryParse(upsal, out temp);
                flag2 = float.TryParse(upid, out temp);
                if (!flag1 || !flag2)
                {
                    MessageBox.Show("输入数字不合法");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = 'True'";
                SqlConnection up_con = new SqlConnection(constr);
                up_con.Open();
                string sel_str = "select * from 职员信息 where 编号 = '"+ upid+"' and 在职 = 'True'";
                string up_str = "update 职员信息  set 姓名 = '" + upname + "' ,性别 = '" + upsex + "' ,职位 = '" + upjob + "' ,工资 = '" + upsal + "' where 编号 = '" + upid + "'and 在职 = 'True'";
                SqlCommand sel_com = new SqlCommand(sel_str, up_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    up_con.Close();
                    up_con.Open();
                    SqlCommand up_com = new SqlCommand(up_str, up_con);
                    int num = up_com.ExecuteNonQuery();
                    y = 1;
                    MessageBox.Show(num + "条信息被修改");
                    return;
                }
                else
                {
                    MessageBox.Show("没有这条信息");
                    return;
                }
            }
            if (comboBox1.Text == "修改注册信息")
            {
                string upuser = username.Text;
                string uppass = password.Text;
                string upright = right.Text;
                if (string.IsNullOrEmpty(upuser) || string.IsNullOrEmpty(uppass) || string.IsNullOrEmpty(upright))
                {
                    MessageBox.Show("信息不得有空");
                    return;
                }
                if (upuser.Length < 5 || upuser.Length > 20||uppass.Length<5||uppass.Length>20)
                {
                    MessageBox.Show("用户名和密码必须在5-20位以内");
                    return;
                }
                string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = 'True'";
                SqlConnection up_con = new SqlConnection(constr);
                up_con.Open();
                string sel_str = "select * from 账户 where ID ='" + upuser + "'";
                string up_str = "update 账户  set PASSWORD = '" + uppass + "' ,JOB = '" + upright + "' where ID = '" + upuser + "'";
                SqlCommand sel_com = new SqlCommand(sel_str, up_con);
                SqlDataReader dr_sel = sel_com.ExecuteReader();
                if (dr_sel.HasRows)
                {
                    up_con.Close();
                    up_con.Open();
                    SqlCommand up_com = new SqlCommand(up_str, up_con);
                    int num = up_com.ExecuteNonQuery();
                    y = 1;
                    MessageBox.Show(num + "条信息被修改");
                    return;
                }
                else
                {
                    MessageBox.Show("没有这条信息");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void 详细信息_Click(object sender, EventArgs e)
        {

        }
    }
}
