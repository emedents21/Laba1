using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6
{
    internal class town : allgood, ITStown
    {

        double t;
        
        public town(double t)
        {
            this.t = t;
        }

        public double T { get { return t; } set { t = value; } }

        public string AllGood()
        {
            return "Оголошено надзвичайний стан!!!";
        }

        public string Negood()
        {
            return "Пошкоджено велику кiлькiсть домiв!!!";
        }

        public void town_Massage()
        {
            if (t > 6)
            {
                MessageBox.Show(AllGood());
            }
            if (t > 7)
            {
                MessageBox.Show(Negood());
            }
        }
    }
}
