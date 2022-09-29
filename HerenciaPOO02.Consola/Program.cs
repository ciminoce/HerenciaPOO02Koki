using System;
using HerenciaPOO02.Datos;
using HerenciaPOO02.Entidades;

namespace HerenciaPOO02.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Publicacion pub = new Publicacion(100, "Hola");
            Libro lib = new Libro(150, "hola2", 77);
            //Console.WriteLine(pub.MostrarDatos());
            Console.WriteLine(lib.MostrarDatos());

            Repositorio lista = new Repositorio();
            //if (lista + pub)
            //{
            //    Console.WriteLine("Registro agregado");
            //    Console.WriteLine(lista.GetCantidad);
            //}
            //else
            //{
            //    Console.WriteLine("Registro no agragado");
            //}
            if (lista + lib)
            {
                Console.WriteLine("Registro agregado");
                Console.WriteLine(lista.GetCantidad);
            }
            else
            {
                Console.WriteLine("Registro no agregado");
            }
            Libro lib1 = new Libro(150, "hola2", 77);

            if (lista + lib1)
            {
                Console.WriteLine("Registro agregado");
                Console.WriteLine(lista.GetCantidad);
            }
            else
            {
                Console.WriteLine("Registro no agregado");
            }

            var libro2 = new Libro(400, "El sol desnudo", 350);
            if (lista + libro2)
            {
                Console.WriteLine("Registro agregado");
                Console.WriteLine(lista.GetCantidad);
            }
            else
            {
                Console.WriteLine("Registro no agregado");
            }



            Console.ReadLine();
        }
    }
}
