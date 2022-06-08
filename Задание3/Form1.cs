using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] b = new int[5, 4];
            Masiv masiv = new Masiv();
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 4;
            b = masiv.a;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = b[i, j];
                }
            }
            textBox1.Text = masiv.Vivod.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Clear();
        }
    }
}
