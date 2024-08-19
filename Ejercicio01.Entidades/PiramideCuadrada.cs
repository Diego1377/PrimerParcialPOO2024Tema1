namespace Ejercicio01.Entidades
{
    public class PiramideCuadrada
    {
        public int Lado { get; }
        public int Altura { get; }

        private double apotema;

        public PiramideCuadrada(int lado, int altura)
        {
            if (lado <= 0)
            {
                throw new ArgumentException("El lado debe ser mayor que cero.");
            }

            if (altura <= 0)
            {
                throw new ArgumentException("La altura debe ser mayor que cero.");
            }

            Lado = lado;
            Altura = altura;
            apotema = CalcularApotema();
        }
        private double CalcularApotema()
        {
            return Math.Sqrt(Math.Pow(Lado / 2, 2) + Math.Pow(Altura, 2));
        }
        public double ObtenerApotema()
        {
            return apotema;
        }
        public double CalcularAreaBase()
        {
            return Math.Pow(Lado, 2);
        }
 
        public double CalcularAreaLateral()
        {
            return 2 * Lado * apotema;
        }

        
        public double CalcularArea()
        {
            return CalcularAreaBase() + CalcularAreaLateral();
        }

        
        public double CalcularVolumen()
        {
            return (Math.Pow(Lado, 2) * Altura) / 3;
        }
        public void InformarDatos()
        {
            Console.WriteLine($"Lado: {Lado}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Apotema: {apotema}");
            Console.WriteLine($"Área de la Base: {CalcularAreaBase()}");
            Console.WriteLine($"Área Lateral: {CalcularAreaLateral()}");
            Console.WriteLine($"Área Total:{CalcularArea()}");
            Console.WriteLine($"Volumen: {CalcularVolumen()}");
        }
    }


}

