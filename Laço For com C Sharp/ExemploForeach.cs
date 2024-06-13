using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoFor
{
    internal class ExemploForeach
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Uno", "Mobi", "Kwid", "206" };
            foreach (string contadora in carro)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}
