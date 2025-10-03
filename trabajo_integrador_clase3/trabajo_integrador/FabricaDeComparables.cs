namespace trabajo_integrador;

public abstract class FabricaDeComparables
{
    public static IComparable CrearAleatorio(int opcion)
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
        
        return fabrica.CrearPorAleatorio();
    }

    public static IComparable CrearPorTeclado(int opcion)
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
        
        return fabrica.CrearPorLector();
    }

    public abstract IComparable CrearPorAleatorio();
    public abstract IComparable CrearPorLector();
}