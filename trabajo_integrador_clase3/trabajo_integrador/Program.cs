namespace trabajo_integrador;

class Program
{
    static void Main(string[] args)
    {
        // ej 6
        /*Console.WriteLine("=== PRUEBA CON NÚMEROS ===");
        Pila pilaNumeros = new Pila();
        llenar(pilaNumeros, 1);
        informar(pilaNumeros, 1);

        Console.WriteLine("\n=== PRUEBA CON ALUMNOS ===");
        Cola colaAlumnos = new Cola();
        llenar(colaAlumnos, 2);
        informar(colaAlumnos, 2);

        Console.WriteLine("\n=== PRUEBA CON PROFESORES ===");
        Conjunto conjuntoProfesores = new Conjunto();
        llenar(conjuntoProfesores, 3);
        informar(conjuntoProfesores, 3);*/
        
        // ej 9
        // IComparable prof = FabricaDeComparables.crearAleatorio(3);
        // Pila pila = new Pila();
        // llenar(pila, 3);
        // informar(pila, 3);
        
        
        // ej 14
        Profesor profesor = (Profesor)FabricaDeComparables.crearAleatorio(3);
        
        Pila col = new Pila();
        llenar(col, 2);

        IIterador iterador = col.crearIterador();
        
        for (iterador.primero(); !iterador.fin(); iterador.siguiente())
        {
            profesor.agregarObservador((IObservador)iterador.actual());
        }
        
        Console.WriteLine("Profesor: " + profesor.getNombre());
        dictadoDeClases(profesor); 
    }

    public static void imprimirElementos(IColeccionable coleccionable)
    {
        IIterable iterable = (IIterable)coleccionable;
        IIterador iterador = iterable.crearIterador();

        while (!iterador.fin())
        {
            Console.WriteLine(iterador.actual());
            iterador.siguiente();
        }
    }

    static void cambiarEstrategia(IColeccionable coleccionable, IEstrategiaComparacion estrategia)
    {
        IIterable iterable = (IIterable)coleccionable; 
        IIterador iterador = iterable.crearIterador();
        iterador.primero();

        while (!iterador.fin())
        {
            Alumno alumno = (Alumno)iterador.actual();
            alumno.setEstrategia(estrategia);
            iterador.siguiente();
        }
    }

    // ej 6
    public static void llenar(IColeccionable coleccionable, int opcion)
    {
        for (int i = 0; i < 20; i++)
        {
            IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
            coleccionable.agregar(comparable);
        }
    }

    public static void informar(IColeccionable coleccionable, int opcion)
    {
        Console.WriteLine("Cantidad de elementos: " + coleccionable.cuantos());
        Console.WriteLine("El mínimo es: " + coleccionable.minimo());
        Console.WriteLine("El máximo es: " + coleccionable.maximo());

        IComparable comparable = FabricaDeComparables.crearPorTeclado(opcion);

        if (coleccionable.contiene(comparable))
            Console.WriteLine("El elemento leído está en la colección.");
        else
            Console.WriteLine("El elemento leído no está en la colección.");
    }

    // ej 13
    public static void dictadoDeClases(Profesor profesor)
    {
        for (int i = 0; i < 5; i++)
        {
            profesor.hablarALaClase();
            profesor.escribirEnElPizarron();
        }
    }
}
