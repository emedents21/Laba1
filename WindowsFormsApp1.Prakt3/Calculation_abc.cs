using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Prakt3
{
    public class Calculation_abc
    {
        int a, b, c;
        public Calculation_abc(int a, int b, int c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        static bool IsOdd(int number)
        {
            // Перевірка, чи число непарне
            return number % 2 != 0;
        }

        public double D()
        {
            if (IsOdd(a) && IsOdd(b) && IsOdd(c))
            {
                // Всі три числа непарні, знаходимо їх суму
                return a + b + c;
            }
            else
            {
                // Якщо хоча б одне число парне або всі числа парні, то знаходимо середнє арифметичне
                return (a + b + c) / 3.0;
            }
        }
    }
}
