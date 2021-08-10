using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU21_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Select ProductID , Quantity from OrtizB21Su2332.Products";
            ProgOps.GrabDiscounts(dataGridView1, str);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {

            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text =  dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cellVal;
            int newCellVal;

            int intQuan = int.Parse(textBox2.Text);
            cellVal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
            newCellVal = Convert.ToInt32(cellVal - intQuan);
            dataGridView1.SelectedRows[0].Cells["Quantity"].Value = newCellVal;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cellVal;
            int newCellVal;

            string searchValue = "30000";
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            dataGridView1.Rows[rowIndex].Selected = true;

            int intQuan = int.Parse(textBox2.Text);
            cellVal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
            newCellVal = Convert.ToInt32(cellVal - intQuan);
            dataGridView1.SelectedRows[0].Cells["Quantity"].Value = newCellVal;
        }
    }
}
