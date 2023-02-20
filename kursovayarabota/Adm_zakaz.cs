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
    public partial class Adm_zakaz : Form
    {
        public Adm_zakaz()
        {
            InitializeComponent();
        }

        private void zakaziBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakaziBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Adm_zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.kursDataSet.zakazi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zakaziDataGridView.RowCount; i++)
            {
                zakaziDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < zakaziDataGridView.ColumnCount; j++)
                    if (zakaziDataGridView.Rows[i].Cells[j].Value != null)
                        if (zakaziDataGridView.Rows[i].Cells[j].Value.ToString().Contains
                        (textBox1.Text))
                        {
                            zakaziDataGridView.Rows[i].Selected = true; break;
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakaziTableAdapter.Update(this.kursDataSet.zakazi);
            MessageBox.Show("Данные сохранены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow row = kursDataSet.Tables["zakazi"].NewRow();
            //row["zakazid"] = textBox13.Text;
            row["zakazname"] = textBox12.Text;
            row["zakazauthor"] = textBox11.Text;
            row["zakazfio"] = textBox10.Text;
            row["zakazadres"] = textBox9.Text;
            row["zakazdate"] = textBox8.Text;
            kursDataSet.Tables["zakazi"].Rows.Add(row);
            zakaziTableAdapter.Update(kursDataSet.zakazi);
            kursDataSet.Tables["zakazi"].AcceptChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakaziTableAdapter.Update(this.kursDataSet.zakazi);
            MessageBox.Show("Данные сохранены");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = zakaziDataGridView.CurrentRow.Index;
            zakaziDataGridView.Rows.Remove(zakaziDataGridView.Rows[a]);
        }
    }
}
