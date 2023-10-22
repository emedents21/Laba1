using System;

namespace Praktika2
{
    class Masiv1
    {
        private int[] mass;

        public Masiv1()
        {
            mass = new int[0];
        }

        public Masiv1(int razmer)
        {
            Random rand = new Random();
            mass = new int[razmer];

            for (int i = 0; i < razmer; i++)
            {
                mass[i] = rand.Next(-15, 30);
            }
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < mass.Length)
                {
                    return mass[i];
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Length
        {
            get { return mass.Length; }
        }

        public int[] Getter()
        {
            return mass;
        }

        public int FindMaxElement()
        {
            if (mass.Length == 0)
            {
                return 0;
            }

            int maxElement = mass[0];

            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > maxElement)
                {
                    maxElement = mass[i];
                }
            }

            return maxElement;
        }

        public int FindMaxIndex()
        {
            if (mass.Length == 0)
            {
                return -1;
            }

            int maxElement = mass[0];
            int maxIndex = 0;

            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > maxElement)
                {
                    maxElement = mass[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}

