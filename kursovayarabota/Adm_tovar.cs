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

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Adm_tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(kursDataSet.book);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow row = kursDataSet.Tables["book"].NewRow();
            //row["bookid"] = textBox7.Text;
            row["bookname"] = textBox6.Text;
            row["bookauthor"] = textBox5.Text;
            row["bookdate"] = textBox7.Text;
            kursDataSet.Tables["book"].Rows.Add(row);
            bookTableAdapter.Update(kursDataSet.book);
            kursDataSet.Tables["book"].AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookTableAdapter.Update(this.kursDataSet.book);
            MessageBox.Show("Данные сохранены");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = bookDataGridView.CurrentRow.Index;
            bookDataGridView.Rows.Remove(bookDataGridView.Rows[a]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookTableAdapter.Update(this.kursDataSet.book);
            MessageBox.Show("Данные сохранены");//IDENTITY
        }
    }
}
