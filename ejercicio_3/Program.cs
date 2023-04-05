using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ancho de la figura: ");
            int ancho = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el alto de la figura: ");
            int alto = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿La figura tiene profundidad? (s/n): ");
            char respuesta = Convert.ToChar(Console.ReadLine());
            bool relleno;
            if (respuesta == 's')
            {
                relleno = true;
            } else
            {
                relleno = false;
            }

            Console.Write("¿Cuántas figuras desea dibujar? ");
            int figuras = Convert.ToInt32(Console.ReadLine());

            // Dibujando la primera línea
            for (int i = 0; i < figuras; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" ");
            }

            Console.Write("\n");

            // Dibujando las líneas intermedias
            if (relleno)
            {
                for (int i = 0; i < alto - 2; i++)
                {
                    for (int j = 0; j < figuras; j++)
                    {
                        for (int k = 0; k < ancho; k++)
                        {
                            Console.Write("*");
                        }

                        Console.Write(" ");
                    }

                    Console.Write("\n");
                }
            } else
            {
                for (int i = 0; i < alto - 2; i++)
                {
                    for (int j = 0; j < figuras; j++)
                    {
                        for (int k = 0; k < ancho; k++)
                        {
                            if (k == 0 || k == ancho - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                        Console.Write(" ");
                    }

                    Console.Write("\n");
                }
            }

            // Dibujando la última línea
            for (int i = 0; i < figuras; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" ");
            }

            Console.Write("\n");
        }
    }
}
