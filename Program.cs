using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe 
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color:");
            color = Console.ReadLine();

            Console.WriteLine("Enter a pluralNoun:");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter the name of a celebrity:");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are" +" " +color);
            Console.WriteLine("Violets are" + " " +pluralNoun);
            Console.WriteLine("I love" + " " + celebrity );
            Console.ReadLine();
                
    

        }
    }
}
