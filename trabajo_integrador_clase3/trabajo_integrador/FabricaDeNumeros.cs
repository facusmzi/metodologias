namespace trabajo_integrador;

public class FabricaDeNumeros : FabricaDeComparables
{
    public override IComparable CrearPorAleatorio()
    {
        int valor = GeneradorDeDatosAleatorios.NumeroAleatorio(100);
        return new Numero(valor);
    }

    public override IComparable CrearPorLector()
    {
        Console.Write("Ingrese un número: ");
        int valor = LectorDeDatos.NumeroPorTeclado();
        return new Numero(valor);
    }
}