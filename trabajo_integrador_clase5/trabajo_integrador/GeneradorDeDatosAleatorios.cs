namespace trabajo_integrador
{
    public class GeneradorDeDatosAleatorios
    {
        private static Random random = new Random();
        private const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static int numeroAleatorio(int max)
        {
            return random.Next(max + 1);
        }

        public static string stringAleatorio(int cant)
        {
            char[] resultado = new char[cant];

            for (int i = 0; i < cant; i++)
            {
                resultado[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(resultado);
        }
    }
}