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
    
    public partial class login_page : Form
    {
        public login_page()
        {

            InitializeComponent();
           
        }
        int i = 0;
        public int Drive(string user,string pass,string right)
        {
            textBox1.Text = user;
            textBox2.Text = pass;
            comboBox1.Text = right;
            object se = new object();
            EventArgs ev = new EventArgs();
            login_button_Click(se, ev);        
            return i;

        }
        public void login_button_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("用户名不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("密码不可为空！");
                return;
            }
            /*if (string.IsNullOrEmpty(comboBox1.Text))
            {
                
                //MessageBox.Show("填写你的权限！");
                //return;
            }*/
            string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
            SqlConnection log_con = new SqlConnection(constr);
            log_con.Open();
            /*if (log_con.State != ConnectionState.Open)
            {
                MessageBox.Show("数据库打开失败！错误位于登录按钮!");
                return;
            }*/
            string userstr = textBox1.Text;
            string passwordstr = textBox2.Text;
            string rightstr = comboBox1.Text;
            string select_user = "SELECT * FROM 账户 WHERE ID='" + userstr + "'";
            SqlCommand cmd = new SqlCommand(select_user,log_con);
           
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                if (dr["PASSWORD"].ToString() == passwordstr)
                {
                    
                    if (dr["JOB"].ToString() == rightstr)
                    {
                        i = 1;
                        
                        if (rightstr == "经理")
                        {
                            
                            Manager_Page form4 = new Manager_Page();
                            form4.ShowDialog();
                            
                        }
                        if (rightstr == "员工")
                        {
                            i = 1;
                            staff_right form3 = new staff_right();
                            form3.ShowDialog();
                           
                        }

                    }
                    else
                    {
                        i = 0;
                        MessageBox.Show("密码或权限有误");
                       // textBox1.Text = "";
                       // textBox2.Text = "";
                        //comboBox1.Text = "";
                    }
                }
                else
                {
                    i = 0;
                    MessageBox.Show("密码或权限有误");

                    //textBox1.Text = "";
                    //textBox2.Text = "";
                   // comboBox1.Text = "";
                }

            }
            else
            {
                i = 0;
                MessageBox.Show("无此用户，检查你的输入");
                //textBox1.Text = "";
                //textBox2.Text = "";
                //comboBox1.Text = "";
            }
            log_con.Close();
        }
        private void user_name_label_Click(object sender, EventArgs e)
        {

        }

        private void user_password_label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] str = new string[] { "经理", "员工" };
            comboBox1.Items.AddRange(str);
            comboBox1.SelectedIndex = 1;
            //comboBox1.Text = "员工";

            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {  
            
            regist form2 = new regist();
            form2.ShowDialog();
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        bool check=false;
        private void radioButton1_Click(object sender, EventArgs e)
        {
            
            
            if (check){
                radioButton1.Checked = false;
                check = false;
            }
            else
            {
                radioButton1.Checked = true;
                check = true;
            }
            if (radioButton1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            if (radioButton1.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void right_label_Click(object sender, EventArgs e)
        {

        }
    }
    
}
