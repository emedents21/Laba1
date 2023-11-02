using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayAB a = new ArrayAB(100);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();
            string patch = "C:\\Users\\Yehor Medentsov\\source\\repos\\Laba1\\Prakt4\\1.txt";
            string patch1 = "C:\\Users\\Yehor Medentsov\\source\\repos\\Laba1\\Prakt4\\2.txt";
            f2.read(patch, a);
            a.Calc();
            f.write(patch1, a);
            label2.Text = show.writeArray(a.a);
            label4.Text = show.writeArray(a.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
