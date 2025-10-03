namespace trabajo_integrador;

public class LectorDeDatos
{
    public static int NumeroPorTeclado()
    {
        return int.Parse(Console.ReadLine()!);
    }

    public static string StringPorTeclado()
    {
        string texto = Console.ReadLine();
        return texto;
    }
}