using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayarabota
{
    public partial class User_menu : Form
    {
        private User_tovar ut;
        public User_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ut = new User_tovar();
            ut.Visible= true;
        }
    }
}
