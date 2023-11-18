using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt5
{
    public partial class Praktika5Tp : Form
    {
        People people = new People();
        string path = "C:\\Users\\Yehor Medentsov\\source\\repos\\Laba1\\Prakt5\\data.txt";
        public void Show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Student p in people.people)
            {
                dg.Rows.Add(p.PIIB, p.Group, p.Exam);
            }
        }
        public Praktika5Tp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                people.ReadFile(path);
                Show(data11111);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                people.WriteFile(path);
                MessageBox.Show("Дані записані!");
            }catch(Exception ex)
            {
                MessageBox.Show("Помилка!");
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                people.people.Add(student);
                data11111.Rows.Add(people.people[people.people.Count - 1].PIIB,
                    people.people[people.people.Count - 1].Group,
                    people.people[people.people.Count - 1].Exam);
            }
            catch (Exception)
            {
                throw new Exception("Помилка у вхідних данних!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var i = data11111.CurrentRow.Index;
            people.Remove(i);
            Show(data11111);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            people.Sort();
            Show(dataGridView2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            people.people.Sort();
            dataGridView1.Rows.Clear();
            foreach (Student p in people.people)
            {
                if(p.Exam > Convert.ToInt32(textBox4.Text))
                {
                    dataGridView1.Rows.Add(p.PIIB, p.Group, p.Exam);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
