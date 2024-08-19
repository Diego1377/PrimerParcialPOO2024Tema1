using Ejercicio01.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lado = ConsoleExtensions.ReadInt("Ingrese el lado de la base: ");
                int altura = ConsoleExtensions.ReadInt("Ingrese la altura: ");

                PiramideCuadrada piramide = new PiramideCuadrada(lado, altura);

                Console.WriteLine("Resultados:");
                piramide.InformarDatos();
            }
            catch (ArgumentException exepcion)
            {
                Console.WriteLine($"Error:{exepcion.Message}");
            }
        }
    }
}
