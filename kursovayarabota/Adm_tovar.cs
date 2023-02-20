using kursovayarabota.kursDataSetTableAdapters;
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
    public partial class Adm_tovar : Form
    {
        public Adm_tovar()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Adm_tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(kursDataSet.books);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < booksDataGridView.RowCount; i++)
            {
                booksDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < booksDataGridView.ColumnCount; j++)
                    if (booksDataGridView.Rows[i].Cells[j].Value != null)
                        if (booksDataGridView.Rows[i].Cells[j].Value.ToString().Contains
                        (textBox1.Text))
                        {
                            booksDataGridView.Rows[i].Selected = true; break;
                        }
            }//40
            }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow row = kursDataSet.Tables["books"].NewRow();
            row["bookid"] = textBox7.Text;
            row["bookname"] = textBox6.Text;
            row["bookauthor"] = textBox5.Text;
            kursDataSet.Tables["books"].Rows.Add(row);
            booksTableAdapter.Update(kursDataSet.books);
            kursDataSet.Tables["books"].AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksTableAdapter.Update(this.kursDataSet.books);
            MessageBox.Show("Данные сохранены");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = booksDataGridView.CurrentRow.Index;
            booksDataGridView.Rows.Remove(booksDataGridView.Rows[a]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksTableAdapter.Update(this.kursDataSet.books);
            MessageBox.Show("Данные сохранены");
        }
    }
}
