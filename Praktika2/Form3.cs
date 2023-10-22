using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Praktika2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0, m = 0;

                m = Convert.ToInt32(textBox1.Text);
                n = Convert.ToInt32(textBox2.Text);

                Masiv2 massive2 = new Masiv2(m, n);

                DataGridViewTextBoxColumn aaa;

                for (int i = 0; i < m; i++)
                {
                    aaa = new DataGridViewTextBoxColumn();
                    aaa.Width = 40;
                    dataGridView1.Columns.Add(aaa);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = massive2.get_m();
                dataGridView1.ColumnCount = massive2.get_n();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = massive2[i, j].ToString();
                    }
                }
                int save = massive2.ProductOfLeftDiagonal(massive2.get_mass());
                int save1 = massive2.SumOfRightDiagonal(massive2.get_mass());
                label3.Text = save1.ToString();
                label4.Text = save.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
