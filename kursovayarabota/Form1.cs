using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayarabota
{
    public partial class login : Form
    {
        public Admin_menu am;
        public User_menu um;
        public login()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.usersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.kursDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pass = Convert.ToString(textBox1.Text);
            if (radioButton1.Checked)
            {
                if (pass == "adminpass")
                {
                    am = new Admin_menu();
                    am.Visible = true;
                }
                else
                {
                    MessageBox.Show("НЕВЕРНЫЙ ПАРОЛЬ!");
                }
            }
            if (radioButton2.Checked)
            {
                if (pass == "userpass")
                {
                    um = new User_menu();
                    um.Visible = true;
                }
                else
                {
                    MessageBox.Show("НЕВЕРНЫЙ ПАРОЛЬ!");
                }
            }
        }
    }
}
