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
    public partial class regist : Form
    {
        int j = 0;
        public regist()
        {
            InitializeComponent();
        }
        public int drive(string user,string pass,string conpass,string right)
        {
            object ob = new object();
            EventArgs se = new EventArgs();
            user_namebox.Text = user;
            password_box.Text = pass;
            confirm_box.Text = conpass;
            right_box.Text = right;
            regist_button_Click(ob, se);
            return j;
        }
        private void return_login_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regist_button_Click(object sender, EventArgs e)
        {
            //right_box.SelectedIndex = 1;
            if (string.IsNullOrEmpty(user_namebox.Text))
            {
                MessageBox.Show("账号为空");
                return;
            }
            else if (string.IsNullOrEmpty(password_box.Text))
            {
                MessageBox.Show("密码为空");
                return;
            }
            else if (string.IsNullOrEmpty(confirm_box.Text))
            {
                MessageBox.Show("确认密码为空");
                return;
            }
            else if (string.IsNullOrEmpty(right_box.Text))
            {
                MessageBox.Show("权限为空");
                return;
            }
            string userstr = user_namebox.Text;
            string password_str = password_box.Text;
            string right = right_box.Text;
            /*if (userstr.Length < 5)
            {
                MessageBox.Show("用户名过短");
                return;
            }
            if (password_str.Length < 5)
            {
                MessageBox.Show("密码过短");
                return;
            }*/
            if (password_box.Text != confirm_box.Text)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }
            string constr = "server = LAPTOP-6O81U8K9; Initial Catalog = market; Integrated Security = True";
            SqlConnection reg_con = new SqlConnection(constr);
            reg_con.Open();
            /*if (reg_con.State != ConnectionState.Open)
            {
                MessageBox.Show("数据库打开失败！错误位于注册页面的注册按钮!");
                return;
            }*/
            
            string select_user = "SELECT * FROM 账户 WHERE ID='" + userstr + "'";
            SqlCommand cmd_sel = new SqlCommand(select_user, reg_con);

            SqlDataReader dr_sel = cmd_sel.ExecuteReader();
            if (dr_sel.HasRows)
            {
                MessageBox.Show("该用户已存在!");
                user_namebox.Text = "";
                reg_con.Close();
                return;
            }
            else
            {
                reg_con.Close();

                string token = "jldkl";//此处为经理账号固定密码前五位
                if (right == "经理")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (password_str[i] != token[i])
                        {
                            MessageBox.Show("请询问经理如何注册经理账号！");
                            password_box.Text = "";
                            confirm_box.Text = "";
                            return;
                        }
                    }
                }
                string insert_str = "insert into 账户(ID,PASSWORD,JOB)values('" + userstr + "','" + password_str + "','" + right + "')";
                SqlCommand reg_cmd = new SqlCommand(insert_str, reg_con);
                try
                {
                    reg_con.Open();
                    int num = reg_cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        j = 1;
                        MessageBox.Show("注册成功");
                        reg_con.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                        reg_con.Close();
                        return;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("错误位于注册添加用户阶段");
                    return;
                }
            }
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
            if (password_box.Text.Length > 10)
            {
                password_box.Text = "";
                MessageBox.Show("输入过长");
                return;
            }
            if (password_box.Text.Length < 5 && password_box.Text.Length > 0)
            {
                label1.Text = "输入的密码过短";
            }
            else
            {
                label1.Text = "";
            }
        }
        

        private void user_namebox_TextChanged(object sender, EventArgs e)
        {
            if (user_namebox.Text.Length > 10)
            {
                user_namebox.Text = "";
                MessageBox.Show("输入过长");
                return;
            }
            if (user_namebox.Text.Length < 5 && user_namebox.Text.Length > 0)
            {
                label1.Text = "输入的账号过短";
            }
            else
            {
                label1.Text = "";
            }

            
        }
       

        private void right_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void confirm_box_TextChanged(object sender, EventArgs e)
        {
            if (confirm_box.Text.Length > 10)
            {
                confirm_box.Text = "";
                MessageBox.Show("输入过长");
                return;
            }
            if (confirm_box.Text.Length < 5 && confirm_box.Text.Length > 0)
            {
                label1.Text = "输入的密码过短";
            }
            else
            {
                label1.Text = "";
            }
        }
        
        private void limit_Click(object sender, EventArgs e)
        {

        }

        private void regist_Load(object sender, EventArgs e)
        {
            string[] str = new string[] { "经理", "员工" };
            right_box.Items.AddRange(str);
            right_box.Text = "员工";
        }

        private void password_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')||e.KeyChar=='\b')
            {
                
            }
            else
            {
                password_box.Text = "";
                e.Handled = true;
                MessageBox.Show("你的输入有误，重新输入！");
                return;
            }
        }

        private void confirm_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b')
            {

            }
            else
            {
                MessageBox.Show("你的输入不符合格式，重新输入！");
                confirm_box.Text = "";
                e.Handled = true;
                
                return;
            }
        }

        private void user_namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b')
            {

            }
            else
            {
                
                MessageBox.Show("你的输入有误，重新输入！");
                
                user_namebox.Clear();
                e.Handled = true;
                /*char temp=Console.ReadKey().KeyChar;
                while( string.IsNullOrEmpty(temp.ToString())){
                    temp = Console.ReadKey().KeyChar;
                }*/
            }

        }
        bool check = false;
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (check)
            {
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
                password_box.PasswordChar = '\0';
                confirm_box.PasswordChar = '\0';
            }
            if (radioButton1.Checked == false)
            {
                password_box.PasswordChar = '*';
                confirm_box.PasswordChar = '*';
            }
        }
    }
}
