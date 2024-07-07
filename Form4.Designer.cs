
namespace WindowsFormsApp3
{
    partial class Manager_Page
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
            this.select_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(225, 138);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(207, 97);
            this.select_button.TabIndex = 0;
            this.select_button.Text = "查询/删除信息";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(225, 349);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(207, 97);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "增加信息";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(629, 138);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(207, 97);
            this.modify_button.TabIndex = 3;
            this.modify_button.Text = "修改信息";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(629, 349);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(207, 97);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "退出登录";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "经理可以增删查改数据库中的任何内容";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 121);
            this.button1.TabIndex = 6;
            this.button1.Text = "本按钮为现场提问的功能，仅供验收时使用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.select_button);
            this.Name = "Manager_Page";
            this.Text = "Manager_Page";
            this.Load += new System.EventHandler(this.Manager_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}