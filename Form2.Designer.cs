
namespace WindowsFormsApp3
{
    partial class regist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regist_button = new System.Windows.Forms.Button();
            this.user_name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.right_box = new System.Windows.Forms.ComboBox();
            this.right = new System.Windows.Forms.Label();
            this.user_namebox = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            this.confirm_box = new System.Windows.Forms.TextBox();
            this.limit = new System.Windows.Forms.Label();
            this.return_login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regist_button
            // 
            this.regist_button.Location = new System.Drawing.Point(503, 292);
            this.regist_button.Name = "regist_button";
            this.regist_button.Size = new System.Drawing.Size(179, 73);
            this.regist_button.TabIndex = 0;
            this.regist_button.Text = "点击此处注册新账号";
            this.regist_button.UseVisualStyleBackColor = true;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Location = new System.Drawing.Point(163, 116);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(44, 18);
            this.user_name_label.TabIndex = 1;
            this.user_name_label.Text = "账号";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(163, 181);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(44, 18);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "密码";
            // 
            // right_box
            // 
            this.right_box.FormattingEnabled = true;
            this.right_box.Location = new System.Drawing.Point(545, 113);
            this.right_box.Name = "right_box";
            this.right_box.Size = new System.Drawing.Size(121, 26);
            this.right_box.TabIndex = 3;
            this.right_box.SelectedIndexChanged += new System.EventHandler(this.right_box_SelectedIndexChanged);
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(474, 116);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(44, 18);
            this.right.TabIndex = 4;
            this.right.Text = "权限";
            // 
            // user_namebox
            // 
            this.user_namebox.Location = new System.Drawing.Point(252, 110);
            this.user_namebox.Name = "user_namebox";
            this.user_namebox.Size = new System.Drawing.Size(100, 28);
            this.user_namebox.TabIndex = 5;
            this.user_namebox.TextChanged += new System.EventHandler(this.user_namebox_TextChanged);
            this.user_namebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_namebox_KeyPress);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(252, 178);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(100, 28);
            this.password_box.TabIndex = 6;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            this.password_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_box_KeyPress);
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Location = new System.Drawing.Point(438, 188);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(80, 18);
            this.confirm_label.TabIndex = 7;
            this.confirm_label.Text = "确认密码";
            // 
            // confirm_box
            // 
            this.confirm_box.Location = new System.Drawing.Point(545, 178);
            this.confirm_box.Name = "confirm_box";
            this.confirm_box.PasswordChar = '*';
            this.confirm_box.Size = new System.Drawing.Size(100, 28);
            this.confirm_box.TabIndex = 8;
            this.confirm_box.TextChanged += new System.EventHandler(this.confirm_box_TextChanged);
            this.confirm_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirm_box_KeyPress);
            // 
            // limit
            // 
            this.limit.AutoSize = true;
            this.limit.Location = new System.Drawing.Point(163, 259);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(530, 18);
            this.limit.TabIndex = 9;
            this.limit.Text = "用户名和密码必须5-10位，可以使用大小写字母和数字，不得为空";
            this.limit.Click += new System.EventHandler(this.limit_Click);
            // 
            // return_login_button
            // 
            this.return_login_button.Location = new System.Drawing.Point(145, 292);
            this.return_login_button.Name = "return_login_button";
            this.return_login_button.Size = new System.Drawing.Size(167, 73);
            this.return_login_button.TabIndex = 10;
            this.return_login_button.Text = "返回登录";
            this.return_login_button.UseVisualStyleBackColor = true;
            this.return_login_button.Click += new System.EventHandler(this.return_login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(163, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(670, 184);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 22);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "显示密码";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "权限不填默认为员工";
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_login_button);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.confirm_box);
            this.Controls.Add(this.confirm_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_namebox);
            this.Controls.Add(this.right);
            this.Controls.Add(this.right_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.regist_button);
            this.Name = "regist";
            this.Text = "Regist_Page";
            this.Load += new System.EventHandler(this.regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regist_button;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.ComboBox right_box;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.TextBox user_namebox;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.TextBox confirm_box;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.Button return_login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
    }
}