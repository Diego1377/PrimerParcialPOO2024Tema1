namespace Ejercicio02.Entidades
{
    public static class ValidadorFecha
    {
        public static bool ValidarFecha(int dia, int mes, int anio)
        {
            if (mes < 1 || mes > 12)
            {
                return false;
            }

            if (dia < 1 || dia > diaMes(mes, anio))
            {
                return false;
            }

            return true;
        }

        private static int diaMes(int mes, int anio)
        {
            switch (mes)
            {
                case 2:
                    return EsBisiesto(anio) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }
        private static bool EsBisiesto(int anio)
        {
            return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
        }
    }
}
