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
        string imgLoc = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG FIles (*.jpg)|*.jpg| GIF Files (*.gif)|*.gif| All Files (*.*)|*.*";
            dialog.Title = "Select Employee Picture";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // ProgOps.UploadPicture(imgLoc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ProgOps.GrabPicture(pictureBox1 , textBox1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strQuery = "Select * from OrtizB21Su2332.Picture";
            ProgOps.GrabDiscounts(dataGridView1, strQuery);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridView1.CurrentRow.Selected = true;
                        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Number"].Value.ToString();

                    }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // ProgOps.GrabPicture(pictureBox1, textBox1);
        }
    }
}
