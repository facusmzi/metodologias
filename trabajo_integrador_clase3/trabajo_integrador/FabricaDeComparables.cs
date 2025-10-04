namespace trabajo_integrador
{
    public abstract class FabricaDeComparables
    {
        public static IComparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null!;

            if (opcion == 1)
            {
                fabrica = new FabricaDeNumeros();
            }
            else if (opcion == 2)
            {
                fabrica = new FabricaDeAlumnos();
            }
            else if (opcion == 3)
            {
                fabrica = new FabricaDeProfesores();
            }

            return fabrica.crearPorAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null!;

            if (opcion == 1)
            {
                fabrica = new FabricaDeNumeros();
            }
            else if (opcion == 2)
            {
                fabrica = new FabricaDeAlumnos();
            }
            else if (opcion == 3)
            {
                fabrica = new FabricaDeProfesores();
            }

            return fabrica.crearPorLector();
        }

        public abstract IComparable crearPorAleatorio();
        public abstract IComparable crearPorLector();
    }
}