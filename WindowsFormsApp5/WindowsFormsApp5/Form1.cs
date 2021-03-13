using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string slka = @"data.base.txt";
            StreamReader sr = new StreamReader(slka, true);
            string line;
            while ((line = sr.ReadLine()) != null) ;
            {
                string[] data = line.Split(';');
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = data[0];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = data[1];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = data[2];
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = data[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
