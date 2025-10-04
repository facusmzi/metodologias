namespace trabajo_integrador
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override IComparable crearPorAleatorio()
        {
            string nombre = GeneradorDeDatosAleatorios.stringAleatorio(8);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(45000000) + 20000000;
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999) + 1000;
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);

            return new Alumno(
                nombre,
                new Numero(dni),
                new Numero(legajo),
                new Numero(promedio)
            );
        }

        public override IComparable crearPorLector()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = LectorDeDatos.stringPorTeclado();

            Console.Write("Ingrese DNI: ");
            int dni = LectorDeDatos.numeroPorTeclado();

            Console.Write("Ingrese legajo: ");
            int legajo = LectorDeDatos.numeroPorTeclado();

            Console.Write("Ingrese promedio: ");
            int promedio = LectorDeDatos.numeroPorTeclado();

            return new Alumno(
                nombre,
                new Numero(dni),
                new Numero(legajo),
                new Numero(promedio)
            );
        }
    }
}