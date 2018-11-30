using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 103; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(-i + " ");
                }
            }

        }
    }
}
