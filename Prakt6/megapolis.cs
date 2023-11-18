using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6
{
    internal class megapolis : allgood, ITSmegapolis
    {
        double t;

        public megapolis(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string AllGood()
        {
            return "Пошкоджено велике мiсто!!";
        }

        public string neegood()
        {
            return "Через землетрус постраждало кiлька мегаполiciв!!!!";
        }


        
        public void megapolis_Massage()
        {
            if (t > 10)
            {
                MessageBox.Show(AllGood());
            }
            if (t > 11)
            {
                MessageBox.Show(neegood());
            }
        }
    }
}
