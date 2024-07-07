using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Manager_Page : Form
    {
        public Manager_Page()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            Form5 sel_del_page = new Form5();
            sel_del_page.ShowDialog();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form6 insert_page = new Form6();
            insert_page.ShowDialog();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            Form7 up_page = new Form7();
            up_page.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manager_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 chaxun = new Form8();
            chaxun.ShowDialog();
        }
    }
}
