using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contPositivos = 0;
            int contNegativos = 0;
            int contCeros = 0;
            char respuesta;
            do {
                Console.Write("Ingresa un número entero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                // Contando los positivos
                if (numero > 0)
                {
                    contPositivos++;
                }
                // Contando los negativos
                if (numero < 0)
                {
                    contNegativos++;
                }
                // Contando los ceros
                if (numero == 0)
                {
                    contCeros++;
                }

                Console.Write("¿Desea ingresar otro número? (s/n): ");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');

            Console.WriteLine($"Números positivos: {contPositivos}");
            Console.WriteLine($"Números negativos: {contNegativos}");
            Console.WriteLine($"Ceros: {contCeros}");
            Console.ReadKey();
        }
    }
}
