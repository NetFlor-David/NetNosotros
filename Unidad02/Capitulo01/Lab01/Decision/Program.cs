using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.Write("Ingrese un texto"+'\n');
            inputTexto = Console.ReadLine();
            if (inputTexto.Length > 0)
            {
                Console.WriteLine("El texto ingresado es: " + inputTexto);
                Console.WriteLine("Menu " +'\n' +
                    "1- Mostrar la frase ingresada en Mayusculas" + '\n' +
                    "2- Mostrar la frase ingresada en Minusculas" + '\n' +
                    "3- Mostrar la cantidad de carácteres en la frase");
                ConsoleKeyInfo opcion = Console.ReadKey();
               switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Su frase en mayúsculas: "+ '\n'+ inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Su frase en mínusculas: " + '\n' +inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("La longitud de su frase es: " + '\n' + inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no es correcta");
                        break;
                }

            }
            else
            {
                Console.WriteLine("No se ingreso texto");
            }



        }
    }
}
