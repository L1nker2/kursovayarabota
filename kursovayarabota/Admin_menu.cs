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
    public partial class Admin_menu : Form
    {
        public Adm_tovar at;
        public Adm_zakaz az;
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            at = new Adm_tovar();
            at.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            az = new Adm_zakaz();
            az.Visible = true;
        }
    }
}
