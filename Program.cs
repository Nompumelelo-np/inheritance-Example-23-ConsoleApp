using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Example_23_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeChicken();
            chef1.MakesPasta();
            chef1.MakeSpecialDish();


            Console.ReadLine();
        }
    }
}
