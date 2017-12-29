using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y presione Enter: ");
            string name = Console.ReadLine();

            Console.WriteLine("Escriba su edad: ");
            int age = int.Parse(Console.ReadLine());

            if(age > 18)
            {
                Console.WriteLine("Tu nombre es "+ name + " y legalmente eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Tu nombre es " + name + " y legalmente no eres mayor de edad.");
            }

        }
    }
}
