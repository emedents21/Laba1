using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(textBox1.Text);
            mistse m1 = new mistse(t);
            oblast ob1 = new oblast(t);
            town tw1 = new town(t);
            megapolis mp1 = new megapolis(t);
            Delegate inf = new Delegate();

            inf.help += new Info(m1.Mistse_Massage);
            inf.help += new Info(ob1.oblast_Massage);
            inf.help += new Info(tw1.town_Massage);
            inf.help += new Info(mp1.megapolis_Massage);
            inf.helping(t);
            MessageBox.Show("Землетрус закiнчився!!!!! УРААА");
        }
    }
}
