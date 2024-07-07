
namespace WindowsFormsApp3
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.scantime_box1 = new System.Windows.Forms.TextBox();
            this.scantime_box2 = new System.Windows.Forms.TextBox();
            this.name_box1 = new System.Windows.Forms.TextBox();
            this.id_box3 = new System.Windows.Forms.TextBox();
            this.name_box2 = new System.Windows.Forms.TextBox();
            this.singlemoney_box = new System.Windows.Forms.TextBox();
            this.id_box4 = new System.Windows.Forms.TextBox();
            this.name_box3 = new System.Windows.Forms.TextBox();
            this.sex_box = new System.Windows.Forms.TextBox();
            this.job_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.right_box = new System.Windows.Forms.TextBox();
            this.id_box2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.total_box = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "扫描时间 起";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "扫描人员编号";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "库存(<)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "人员编号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "姓名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "职位";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "商品编号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "性别";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "商品名称";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(869, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 18);
            this.label17.TabIndex = 16;
            this.label17.Text = "用户名";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(887, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "权限";
            // 
            // scantime_box1
            // 
            this.scantime_box1.Location = new System.Drawing.Point(176, 94);
            this.scantime_box1.Name = "scantime_box1";
            this.scantime_box1.Size = new System.Drawing.Size(100, 28);
            this.scantime_box1.TabIndex = 19;
            // 
            // scantime_box2
            // 
            this.scantime_box2.Location = new System.Drawing.Point(176, 139);
            this.scantime_box2.Name = "scantime_box2";
            this.scantime_box2.ReadOnly = true;
            this.scantime_box2.Size = new System.Drawing.Size(100, 28);
            this.scantime_box2.TabIndex = 20;
            this.scantime_box2.Visible = false;
            // 
            // name_box1
            // 
            this.name_box1.Location = new System.Drawing.Point(176, 176);
            this.name_box1.Name = "name_box1";
            this.name_box1.Size = new System.Drawing.Size(100, 28);
            this.name_box1.TabIndex = 21;
            // 
            // id_box3
            // 
            this.id_box3.Location = new System.Drawing.Point(450, 94);
            this.id_box3.Name = "id_box3";
            this.id_box3.Size = new System.Drawing.Size(100, 28);
            this.id_box3.TabIndex = 23;
            // 
            // name_box2
            // 
            this.name_box2.Location = new System.Drawing.Point(450, 136);
            this.name_box2.Name = "name_box2";
            this.name_box2.Size = new System.Drawing.Size(100, 28);
            this.name_box2.TabIndex = 24;
            // 
            // singlemoney_box
            // 
            this.singlemoney_box.Location = new System.Drawing.Point(450, 176);
            this.singlemoney_box.Name = "singlemoney_box";
            this.singlemoney_box.Size = new System.Drawing.Size(100, 28);
            this.singlemoney_box.TabIndex = 25;
            // 
            // id_box4
            // 
            this.id_box4.Location = new System.Drawing.Point(711, 91);
            this.id_box4.Name = "id_box4";
            this.id_box4.Size = new System.Drawing.Size(100, 28);
            this.id_box4.TabIndex = 26;
            // 
            // name_box3
            // 
            this.name_box3.Location = new System.Drawing.Point(711, 136);
            this.name_box3.Name = "name_box3";
            this.name_box3.Size = new System.Drawing.Size(100, 28);
            this.name_box3.TabIndex = 27;
            // 
            // sex_box
            // 
            this.sex_box.Location = new System.Drawing.Point(711, 179);
            this.sex_box.Name = "sex_box";
            this.sex_box.Size = new System.Drawing.Size(100, 28);
            this.sex_box.TabIndex = 28;
            // 
            // job_box
            // 
            this.job_box.Location = new System.Drawing.Point(711, 220);
            this.job_box.Name = "job_box";
            this.job_box.Size = new System.Drawing.Size(100, 28);
            this.job_box.TabIndex = 29;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(952, 91);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(100, 28);
            this.username_box.TabIndex = 30;
            // 
            // right_box
            // 
            this.right_box.Location = new System.Drawing.Point(952, 139);
            this.right_box.Name = "right_box";
            this.right_box.Size = new System.Drawing.Size(100, 28);
            this.right_box.TabIndex = 31;
            // 
            // id_box2
            // 
            this.id_box2.Location = new System.Drawing.Point(176, 223);
            this.id_box2.Name = "id_box2";
            this.id_box2.Size = new System.Drawing.Size(100, 28);
            this.id_box2.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 84);
            this.button1.TabIndex = 33;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(47, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(764, 326);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 64);
            this.contextMenuStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.contextMenuStrip1_PreviewKeyDown);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 26);
            this.comboBox1.TabIndex = 37;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 22);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "扫描时间使用时间段";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "总价(>)";
            // 
            // total_box
            // 
            this.total_box.Location = new System.Drawing.Point(176, 266);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(100, 28);
            this.total_box.TabIndex = 40;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(450, 223);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 22);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "打折";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 84);
            this.button2.TabIndex = 43;
            this.button2.Text = "退出本窗口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 762);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.total_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_box2);
            this.Controls.Add(this.right_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.job_box);
            this.Controls.Add(this.sex_box);
            this.Controls.Add(this.name_box3);
            this.Controls.Add(this.id_box4);
            this.Controls.Add(this.singlemoney_box);
            this.Controls.Add(this.name_box2);
            this.Controls.Add(this.id_box3);
            this.Controls.Add(this.name_box1);
            this.Controls.Add(this.scantime_box2);
            this.Controls.Add(this.scantime_box1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox scantime_box1;
        private System.Windows.Forms.TextBox scantime_box2;
        private System.Windows.Forms.TextBox name_box1;
        private System.Windows.Forms.TextBox id_box3;
        private System.Windows.Forms.TextBox name_box2;
        private System.Windows.Forms.TextBox singlemoney_box;
        private System.Windows.Forms.TextBox id_box4;
        private System.Windows.Forms.TextBox name_box3;
        private System.Windows.Forms.TextBox sex_box;
        private System.Windows.Forms.TextBox job_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox right_box;
        private System.Windows.Forms.TextBox id_box2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
    }
}