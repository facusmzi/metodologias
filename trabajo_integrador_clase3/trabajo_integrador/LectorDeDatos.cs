namespace trabajo_integrador
{
    public class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine()!);
        }

        public static string stringPorTeclado()
        {
            string texto = Console.ReadLine()!;
            return texto;
        }
    }
}