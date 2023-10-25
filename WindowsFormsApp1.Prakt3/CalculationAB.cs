using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Prakt3
{
    public class CalculationAB
    {
        int a, b;
        public CalculationAB(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public int A { get { return a; } }
        public int B { get { return b; } }

        public int Sun()
        {
            if (a > b)
            {
                throw new ArgumentOutOfRangeException("A should be less than B");
            }
            if (a == b) 
            {
                return 0;
            }
            else
            {
                int count = 0;
                for (int i = a; i < b; i++)
                {
                    if (i % 5 == 4 && i % 6 == 5) 
                    {
                        count++;
                    }
                }
                return count;
            }
        }

    }
}
