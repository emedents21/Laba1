using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6
{
    delegate void Info();
    internal class Delegate
    {

        public event Info help;

        public void helping(double t)
        {
            if (t >= 0) { help(); }
        }
    }
}
