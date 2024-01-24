using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Example_23_ConsoleApp
{
    internal class ItalianChef:Chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("The Chef makes Pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Special Dishes");
        }
    }
}
