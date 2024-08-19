using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = 23, mes = 10, anio = 2024;

            bool esValida = ValidadorFecha.ValidarFecha(dia, mes, anio);
            Console.WriteLine($"Fecha: {dia}/{mes}/{anio} es {(esValida ? "no Bisiesto" : "Bisiesto")}");

            dia = 23; mes = 2; anio = 2023;
            esValida = ValidadorFecha.ValidarFecha(dia, mes, anio);
            Console.WriteLine($"Fecha: {dia}/{mes}/{anio} es {(esValida ? "no Bisiesto" : "Bisiesto")}");

        }
    }
}
