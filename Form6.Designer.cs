
namespace WindowsFormsApp3
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.商品编号 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.year_box = new System.Windows.Forms.TextBox();
            this.scid_box = new System.Windows.Forms.TextBox();
            this.scname_box = new System.Windows.Forms.TextBox();
            this.scsin_box = new System.Windows.Forms.TextBox();
            this.mass_box = new System.Windows.Forms.TextBox();
            this.total_box = new System.Windows.Forms.TextBox();
            this.scanid_box = new System.Windows.Forms.TextBox();
            this.goods_id = new System.Windows.Forms.TextBox();
            this.goods_name = new System.Windows.Forms.TextBox();
            this.goods_sin = new System.Windows.Forms.TextBox();
            this.goods_store = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.right_box = new System.Windows.Forms.TextBox();
            this.staname = new System.Windows.Forms.TextBox();
            this.stasex = new System.Windows.Forms.TextBox();
            this.staid = new System.Windows.Forms.TextBox();
            this.stajob = new System.Windows.Forms.TextBox();
            this.stasal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ifdiscount = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.month_box = new System.Windows.Forms.TextBox();
            this.day_box = new System.Windows.Forms.TextBox();
            this.hour_box = new System.Windows.Forms.TextBox();
            this.second_box = new System.Windows.Forms.TextBox();
            this.min_box = new System.Windows.Forms.TextBox();
            this.exsecond_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "扫描时间(年)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 商品编号
            // 
            this.商品编号.AutoSize = true;
            this.商品编号.Location = new System.Drawing.Point(45, 40);
            this.商品编号.Name = "商品编号";
            this.商品编号.Size = new System.Drawing.Size(80, 18);
            this.商品编号.TabIndex = 1;
            this.商品编号.Text = "商品编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "质量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "扫描人员编号";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "总价";
            // 
            // year_box
            // 
            this.year_box.Location = new System.Drawing.Point(141, 312);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(100, 28);
            this.year_box.TabIndex = 7;
            this.year_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_box_KeyPress);
            // 
            // scid_box
            // 
            this.scid_box.Location = new System.Drawing.Point(141, 37);
            this.scid_box.Name = "scid_box";
            this.scid_box.Size = new System.Drawing.Size(100, 28);
            this.scid_box.TabIndex = 8;
            this.scid_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scid_box_KeyPress);
            // 
            // scname_box
            // 
            this.scname_box.Location = new System.Drawing.Point(141, 82);
            this.scname_box.Name = "scname_box";
            this.scname_box.Size = new System.Drawing.Size(100, 28);
            this.scname_box.TabIndex = 9;
            // 
            // scsin_box
            // 
            this.scsin_box.Location = new System.Drawing.Point(141, 127);
            this.scsin_box.Name = "scsin_box";
            this.scsin_box.Size = new System.Drawing.Size(100, 28);
            this.scsin_box.TabIndex = 10;
            // 
            // mass_box
            // 
            this.mass_box.Location = new System.Drawing.Point(141, 173);
            this.mass_box.Name = "mass_box";
            this.mass_box.Size = new System.Drawing.Size(100, 28);
            this.mass_box.TabIndex = 11;
            // 
            // total_box
            // 
            this.total_box.Location = new System.Drawing.Point(141, 220);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(100, 28);
            this.total_box.TabIndex = 12;
            // 
            // scanid_box
            // 
            this.scanid_box.Location = new System.Drawing.Point(141, 269);
            this.scanid_box.Name = "scanid_box";
            this.scanid_box.Size = new System.Drawing.Size(100, 28);
            this.scanid_box.TabIndex = 13;
            this.scanid_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scanid_box_KeyPress);
            // 
            // goods_id
            // 
            this.goods_id.Location = new System.Drawing.Point(441, 37);
            this.goods_id.Name = "goods_id";
            this.goods_id.Size = new System.Drawing.Size(100, 28);
            this.goods_id.TabIndex = 14;
            this.goods_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goods_id_KeyPress);
            // 
            // goods_name
            // 
            this.goods_name.Location = new System.Drawing.Point(441, 82);
            this.goods_name.Name = "goods_name";
            this.goods_name.Size = new System.Drawing.Size(100, 28);
            this.goods_name.TabIndex = 15;
            // 
            // goods_sin
            // 
            this.goods_sin.Location = new System.Drawing.Point(441, 130);
            this.goods_sin.Name = "goods_sin";
            this.goods_sin.Size = new System.Drawing.Size(100, 28);
            this.goods_sin.TabIndex = 16;
            // 
            // goods_store
            // 
            this.goods_store.Location = new System.Drawing.Point(441, 173);
            this.goods_store.Name = "goods_store";
            this.goods_store.Size = new System.Drawing.Size(100, 28);
            this.goods_store.TabIndex = 17;
            // 
            // user_box
            // 
            this.user_box.Location = new System.Drawing.Point(997, 37);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(100, 28);
            this.user_box.TabIndex = 19;
            this.user_box.Visible = false;
            this.user_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_box_KeyPress);
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(997, 82);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(100, 28);
            this.pass_box.TabIndex = 20;
            this.pass_box.Visible = false;
            // 
            // right_box
            // 
            this.right_box.Location = new System.Drawing.Point(997, 127);
            this.right_box.Name = "right_box";
            this.right_box.Size = new System.Drawing.Size(100, 28);
            this.right_box.TabIndex = 21;
            this.right_box.Visible = false;
            // 
            // staname
            // 
            this.staname.Location = new System.Drawing.Point(715, 82);
            this.staname.Name = "staname";
            this.staname.Size = new System.Drawing.Size(100, 28);
            this.staname.TabIndex = 22;
            this.staname.Visible = false;
            // 
            // stasex
            // 
            this.stasex.Location = new System.Drawing.Point(715, 130);
            this.stasex.Name = "stasex";
            this.stasex.Size = new System.Drawing.Size(100, 28);
            this.stasex.TabIndex = 23;
            this.stasex.Visible = false;
            this.stasex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stasex_KeyPress);
            // 
            // staid
            // 
            this.staid.Location = new System.Drawing.Point(715, 37);
            this.staid.Name = "staid";
            this.staid.Size = new System.Drawing.Size(100, 28);
            this.staid.TabIndex = 24;
            this.staid.Visible = false;
            this.staid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staid_KeyPress);
            // 
            // stajob
            // 
            this.stajob.Location = new System.Drawing.Point(715, 173);
            this.stajob.Name = "stajob";
            this.stajob.Size = new System.Drawing.Size(100, 28);
            this.stajob.TabIndex = 25;
            this.stajob.Visible = false;
            // 
            // stasal
            // 
            this.stasal.Location = new System.Drawing.Point(715, 227);
            this.stasal.Name = "stasal";
            this.stasal.Size = new System.Drawing.Size(100, 28);
            this.stasal.TabIndex = 26;
            this.stasal.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "商品编号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "商品名称";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "单价";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "库存";
            // 
            // ifdiscount
            // 
            this.ifdiscount.AutoSize = true;
            this.ifdiscount.Location = new System.Drawing.Point(436, 221);
            this.ifdiscount.Name = "ifdiscount";
            this.ifdiscount.Size = new System.Drawing.Size(105, 22);
            this.ifdiscount.TabIndex = 48;
            this.ifdiscount.TabStop = true;
            this.ifdiscount.Text = "是否打折";
            this.ifdiscount.UseVisualStyleBackColor = true;
            this.ifdiscount.CheckedChanged += new System.EventHandler(this.ifdiscount_CheckedChanged);
            this.ifdiscount.Click += new System.EventHandler(this.ifdiscount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 116);
            this.button2.TabIndex = 50;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(918, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 26);
            this.comboBox1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "月";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "日";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(273, 315);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 18);
            this.label21.TabIndex = 54;
            this.label21.Text = "时";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(273, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 18);
            this.label22.TabIndex = 55;
            this.label22.Text = "分";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(273, 394);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 18);
            this.label23.TabIndex = 56;
            this.label23.Text = "秒";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(201, 438);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 18);
            this.label24.TabIndex = 57;
            this.label24.Text = "秒后小数点";
            // 
            // month_box
            // 
            this.month_box.Location = new System.Drawing.Point(140, 354);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(100, 28);
            this.month_box.TabIndex = 58;
            this.month_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.month_box_KeyPress);
            // 
            // day_box
            // 
            this.day_box.Location = new System.Drawing.Point(140, 391);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(100, 28);
            this.day_box.TabIndex = 59;
            this.day_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.day_box_KeyPress);
            // 
            // hour_box
            // 
            this.hour_box.Location = new System.Drawing.Point(305, 312);
            this.hour_box.Name = "hour_box";
            this.hour_box.Size = new System.Drawing.Size(100, 28);
            this.hour_box.TabIndex = 60;
            this.hour_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_box_KeyPress);
            // 
            // second_box
            // 
            this.second_box.Location = new System.Drawing.Point(305, 391);
            this.second_box.Name = "second_box";
            this.second_box.Size = new System.Drawing.Size(100, 28);
            this.second_box.TabIndex = 61;
            this.second_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_box_KeyPress);
            // 
            // min_box
            // 
            this.min_box.Location = new System.Drawing.Point(305, 354);
            this.min_box.Name = "min_box";
            this.min_box.Size = new System.Drawing.Size(100, 28);
            this.min_box.TabIndex = 62;
            this.min_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.min_box_KeyPress);
            // 
            // exsecond_box
            // 
            this.exsecond_box.Location = new System.Drawing.Point(305, 435);
            this.exsecond_box.Name = "exsecond_box";
            this.exsecond_box.ReadOnly = true;
            this.exsecond_box.Size = new System.Drawing.Size(100, 28);
            this.exsecond_box.TabIndex = 63;
            this.exsecond_box.Text = "000";
            this.exsecond_box.TextChanged += new System.EventHandler(this.exsecond_box_TextChanged);
            this.exsecond_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exsecond_box_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 59);
            this.button1.TabIndex = 64;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exsecond_box);
            this.Controls.Add(this.min_box);
            this.Controls.Add(this.second_box);
            this.Controls.Add(this.hour_box);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ifdiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stasal);
            this.Controls.Add(this.stajob);
            this.Controls.Add(this.staid);
            this.Controls.Add(this.stasex);
            this.Controls.Add(this.staname);
            this.Controls.Add(this.right_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.goods_store);
            this.Controls.Add(this.goods_sin);
            this.Controls.Add(this.goods_name);
            this.Controls.Add(this.goods_id);
            this.Controls.Add(this.scanid_box);
            this.Controls.Add(this.total_box);
            this.Controls.Add(this.mass_box);
            this.Controls.Add(this.scsin_box);
            this.Controls.Add(this.scname_box);
            this.Controls.Add(this.scid_box);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.商品编号);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 商品编号;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox year_box;
        private System.Windows.Forms.TextBox scid_box;
        private System.Windows.Forms.TextBox scname_box;
        private System.Windows.Forms.TextBox scsin_box;
        private System.Windows.Forms.TextBox mass_box;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.TextBox scanid_box;
        private System.Windows.Forms.TextBox goods_id;
        private System.Windows.Forms.TextBox goods_name;
        private System.Windows.Forms.TextBox goods_sin;
        private System.Windows.Forms.TextBox goods_store;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox right_box;
        private System.Windows.Forms.TextBox staname;
        private System.Windows.Forms.TextBox stasex;
        private System.Windows.Forms.TextBox staid;
        private System.Windows.Forms.TextBox stajob;
        private System.Windows.Forms.TextBox stasal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton ifdiscount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox month_box;
        private System.Windows.Forms.TextBox day_box;
        private System.Windows.Forms.TextBox hour_box;
        private System.Windows.Forms.TextBox second_box;
        private System.Windows.Forms.TextBox min_box;
        private System.Windows.Forms.TextBox exsecond_box;
        private System.Windows.Forms.Button button1;
    }
}