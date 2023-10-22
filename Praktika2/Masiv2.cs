using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2
{
    internal class Masiv2
    {
        int m = 5;
        int n = 5;
        int[,] mass;

        public Masiv2(int rolls, int colls)
        {
            m = rolls;
            n = colls;

            mass = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-20, 20);
                }
            }

        }
        public Masiv2()
        {
            mass = new int[m, n];
            Random rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-20, 20);
                }
            }
        }

        public int get_m()
        {
            return m;
        }

        public int get_n()
        {
            return n;
        }

        public int[,] get_mass()
        {
            return mass;
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && j >= 0)
                {
                    return mass[i, j];
                }
                else
                {
                    return 0;
                }
            }
        }

        public  int SumOfRightDiagonal(int[,] mass)
        {
            int sum = 0;
            int n = mass.GetLength(0); // Розмірність матриці (кількість рядків)

            for (int i = 0; i < n; i++)
            {
                sum += mass[i, i]; // Додаємо елементи правої діагоналі
            }

            return sum;
        }

        public int ProductOfLeftDiagonal(int[,] mass)
        {
            int product = 1;
            int n = mass.GetLength(0); // Розмірність матриці (кількість рядків)

            for (int i = 0; i < n; i++)
            {
                product *= mass[i, n - 1 - i]; // Добуток елементів лівої діагоналі
            }

            return product;
        }

    }
}

