using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Efectos de pasar el arreglo entero" +
            "llamada por refrencia\n\nLos elementos del arreglo " +
            "original son \n\t");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(" {0} ", a[i]);
            ModificarArreglo(a); // el arreglo es pasado por referencia
            Console.WriteLine("\n\nLos valores del arreglo modificado son:\n\t");
            // despliega los elementos del arreglo a
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(" {0} ", a[i]);
            Console.WriteLine("\n\nEfectos de pasar un elemento " +
            "del arreglo, llamada-por-valor \n\n" +
            "a[ 3 ] antes de ModificarElemento: {0}", a[3]);
            // elemento del arreglo pasado en llamada-por-valor
            ModificarElemento(a[3]);
            Console.WriteLine("\na[ 3 ] despues de ModificarElemento: {0}", a[3]);
            Console.ReadLine();
        }
        // método que modifica el arreglo que recive,
        // se modifica el arreglo original
        public static void ModificarArreglo(int[] b)
        {
            for (int j = 0; j < b.Length; j++)
                b[j] *= 2;
        }
        // método que modifica el entero pasado a este
        // el original no será modificado
        public static void ModificarElemento(int e)
        {
            Console.WriteLine("\nvalor recibido en ModificarElemento: {0}", e);
            e *= 2;
            Console.WriteLine("\nvalor calulado en ModificarElemento: {0}", e);
        }
    }
}
