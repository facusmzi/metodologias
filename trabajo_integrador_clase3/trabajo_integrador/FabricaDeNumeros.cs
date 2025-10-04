namespace trabajo_integrador
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override IComparable crearPorAleatorio()
        {
            int valor = GeneradorDeDatosAleatorios.numeroAleatorio(100);
            return new Numero(valor);
        }

        public override IComparable crearPorLector()
        {
            Console.Write("Ingrese un número: ");
            int valor = LectorDeDatos.numeroPorTeclado();
            return new Numero(valor);
        }
    }
}