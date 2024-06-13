using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoFor
{
    internal class NomeForeach
    {
        public static void Main (string[] args)
        {
            string[] nomes = {"Grazielly","Enzzo","Gabriel","Guilherme","Jailson"};
            foreach (string i in nomes) {
                Console.WriteLine(i);
            }
        }
    }
}
