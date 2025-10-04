namespace trabajo_integrador
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override IComparable crearPorAleatorio()
        {
            string nombre = GeneradorDeDatosAleatorios.stringAleatorio(8);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(45000000) + 20000000;
            int antiguedad = GeneradorDeDatosAleatorios.numeroAleatorio(40);

            return new Profesor(
                nombre,
                new Numero(dni),
                new Numero(antiguedad)
            );
        }

        public override IComparable crearPorLector()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = LectorDeDatos.stringPorTeclado();

            Console.Write("Ingrese DNI: ");
            int dni = LectorDeDatos.numeroPorTeclado();

            Console.Write("Ingrese antigüedad (años): ");
            int antiguedad = LectorDeDatos.numeroPorTeclado();

            return new Profesor(
                nombre,
                new Numero(dni),
                new Numero(antiguedad)
            );
        }
    }
}