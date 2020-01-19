using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Los arreglos son siempre de tipo referencia, la variable se va almacenar en el slack pero se va ha apuntar al blo que de memoria del head. Hay que especificar el tamaño inicial del arreglo

            //int[] numeros = new int[4] { 1, 2, 3, 4,};

            //// Recorremos con FOR

            //for (int i = 0; i < numeros.Length; i++) 
            //{

            //    Console.WriteLine(numeros[i]);
            //}
            //Console.ReadLine();

            //// Recorremos con FOREACH

            //foreach (var numero in numeros) 
            //{

            //    Console.WriteLine(numeros);
            //}

            //Console.ReadLine();

            //var tipo = numeros.GetType();

            //int numero3 = numeros[2];
            //int numero4 = numeros[3];

            //try
            //{

            //    int numero10 = numeros[9];

            //}


            //catch (Exception ex) 
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadLine();
            //// Tambien podriamos declarar un arreglo de forma mas sencilla sin especificar el numero de numeros

            //int[] numerosFacil = { 21, 42, 35, 26 };
            //Console.WriteLine(numerosFacil);

            //var cadenas = new [] { 3, 5, 8, 10 };

            //var personas = new[]
            //{
            //    new { Nombre ="Hector"},
            //    new { Nombre =" Julian"}

            //};


            //Circulo[] circulosDeclaracionLarga = new Circulo[2];
            //Circulo[] circulos = { 
            //    new Circulo (20),
            //    new Circulo(5)};


            //var datos = Inicializar();



            // Copiar Datos de un Arreglo a otro Arreglo

            int[] arreglo = new[] { 1, 2, 3, 4, 5, };
            int[] arreglo2 = (int [])arreglo.Clone();


            Array.Copy(arreglo, arreglo2, arreglo.Length);
           
            //for (int i = 0; i < arreglo.Length; i++) 
            //{

            //   arreglo2[i] = arreglo[i] ;
            //}
        }

        static void GenerarReporte(int[] reporte)
        {


        }

        static int[] Inicializar()
        {
            Console.WriteLine("Numero de elementos");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Valor por elemento");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i] = dato;

            }
            return numeros;
        }


    }


}
