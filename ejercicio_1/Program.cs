using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= 10) {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                i++;
            }
        }
    }
}
