using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6
{
    internal class mistse : allgood, ITSmistse1
    {
        double t;
        public mistse(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string AllGood()
        {
            return "Землетрус не сильний нiхто не постраждав!";
        }
      
        public string Middle()
        {
            return "Через землетрус постраждало мiсце!";
        }
        


        public void Mistse_Massage()
        {
            if (t > 3)
            {
                MessageBox.Show(Middle());
            }
            else
            {
                MessageBox.Show(AllGood());
            }
        }
    }
}
