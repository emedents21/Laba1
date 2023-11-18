using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6
{
    internal class oblast : allgood, ITSoblast
    {

        double t;

        public oblast(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string AllGood()
        {
            return "Землетрус пошкодив 20 тис м.кв!";
        }
        
        public string Notgood()
        {
            return "Через землетрус постраждала область!";
        }


        public void oblast_Massage()
        {
            if (t > 4)
            {
                MessageBox.Show(AllGood());
            }
            if (t > 5)
            {
                MessageBox.Show(Notgood());
            }
        }
    }
}
