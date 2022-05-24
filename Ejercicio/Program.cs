using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variable global 
            int num;
            

            // inicio de excepciones
            try
            {
                Console.Write("Ingrese un número entero: ");
                num = Int16.Parse(Console.ReadLine());
                Console.Clear();           

                // despliegue de resultados
                Console.WriteLine("Resultado de elevar al cuadrado: " + Math.Pow(num, 2));
                Console.ReadKey();
            }

            catch (FormatException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }

            catch (OverflowException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }            

            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
