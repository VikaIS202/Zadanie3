using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Masiv
    {
        int sum;
        public int[,] a = new int[5,4];
        Random r = new Random();

        public Masiv()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i,j] = r.Next(-5, 20);
                }
            }
        }
        public int Summa()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += a[i,j];
                }
            }
            return sum;
        }

        public int Vivod
        {
            get { return Summa();}
        }
    }
}
