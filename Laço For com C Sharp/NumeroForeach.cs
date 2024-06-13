using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoFor
{
    internal class NumeroForeach
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
