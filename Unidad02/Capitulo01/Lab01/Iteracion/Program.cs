using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                string inputTexto;
                Console.Write("Ingrese un texto" + '\n');
                inputTexto = Console.ReadLine();
                arreglo[i] = inputTexto;   
            }
            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine("Texto ingresado en la posición " + (i+1));
                Console.WriteLine(arreglo[i]);
            }
        }
    }
}
