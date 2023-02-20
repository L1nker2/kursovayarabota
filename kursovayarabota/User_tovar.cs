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
    public partial class User_tovar : Form
    {
        public User_tovar()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void User_tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.kursDataSet.zakazi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.kursDataSet.book);
            this.zakaziTableAdapter.Fill(this.kursDataSet.zakazi);
            groupBox1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < bookDataGridView.RowCount; i++)
            {
                bookDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < bookDataGridView.ColumnCount; j++)
                    if (bookDataGridView.Rows[i].Cells[j].Value != null)
                        if (bookDataGridView.Rows[i].Cells[j].Value.ToString().Contains
                        (textBox1.Text))
                        {
                            bookDataGridView.Rows[i].Selected = true; break;
                        }
            }//40
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = kursDataSet.Tables["zakazi"].NewRow();
            //row["bookid"] = textBox7.Text;
            row["zakazname"] = textBox2.Text;
            row["zakazauthor"] = textBox3.Text;
            row["zakazfio"] = textBox4.Text;
            row["zakazadres"] = textBox5.Text;
            row["zakazdate"] = textBox6.Text;
            kursDataSet.Tables["zakazi"].Rows.Add(row);
            zakaziTableAdapter.Update(kursDataSet.zakazi);
            kursDataSet.Tables["zakazi"].AcceptChanges();
            MessageBox.Show("ЗАКАЗ УСПЕШНО ОФОРМЛЕН!");
        }
    }
}
