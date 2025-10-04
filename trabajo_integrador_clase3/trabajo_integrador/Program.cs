namespace trabajo_integrador;

class Program
{

    


    static void Main(string[] args)
    {
        
        // ej 6
        /*Console.WriteLine("=== PRUEBA CON NÚMEROS ===");
        Pila pilaNumeros = new Pila();
        Llenar(pilaNumeros, 1);
        Informar(pilaNumeros, 1);

        Console.WriteLine("\n=== PRUEBA CON ALUMNOS ===");
        Cola colaAlumnos = new Cola();
        Llenar(colaAlumnos, 2);
        Informar(colaAlumnos, 2);

        Console.WriteLine("\n=== PRUEBA CON PROFESORES ===");
        Conjunto conjuntoProfesores = new Conjunto();
        Llenar(conjuntoProfesores, 3);
        Informar(conjuntoProfesores, 3);*/
        
        
        // ej 9
        // IComparable prof = FabricaDeComparables.CrearAleatorio(3);
        // Pila pila = new Pila();
        // Llenar(pila, 3);
        // Informar(pila, 3);
        
        Profesor profesor = (Profesor)FabricaDeComparables.CrearAleatorio(3);
	    	
        Pila col = new Pila();
        Llenar(col, 2);

        IIterador iterador = col.CrearIterador();
	    	
        for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
        {
            profesor.AgregarObservador((IObservador)iterador.Actual());
        }
	    	
        Console.WriteLine("Profesor: " + profesor.Nombre);
        DictadoDeClases(profesor); 

        
        
    }
    
    
    
    public static void ImprimirElementos(IColeccionable coleccionable)
    {
        
        IIterable iterable = (IIterable)coleccionable;
        IIterador iterador = iterable.CrearIterador();
    
        while (!iterador.Fin())
        {
            Console.WriteLine(iterador.Actual());
            iterador.Siguiente();
        }
    }
    
    
    static void CambiarEstrategia(IColeccionable coleccionable, IEstrategiaComparacion estrategia)
    {
        IIterable iterable = (IIterable)coleccionable; 
        IIterador iterador = iterable.CrearIterador();
        iterador.Primero();

        while (!iterador.Fin())
        {
            Alumno alumno = (Alumno)iterador.Actual(); 
            alumno.Estrategia = estrategia;
            iterador.Siguiente();
        }
    }
    
    
    // ej 6
    public static void Llenar(IColeccionable coleccionable, int opcion)
    {
        for (int i = 0; i < 20; i++)
        {
            IComparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
            coleccionable.Agregar(comparable);
        }
    }

    public static void Informar(IColeccionable coleccionable, int opcion)
    {
        Console.WriteLine("Cantidad de elementos: " + coleccionable.Cuantos());
        Console.WriteLine("El mínimo es: " + coleccionable.Minimo());
        Console.WriteLine("El máximo es: " + coleccionable.Maximo());

        IComparable comparable = FabricaDeComparables.CrearPorTeclado(opcion);

        if (coleccionable.Contiene(comparable))
            Console.WriteLine("El elemento leído está en la colección.");
        else
            Console.WriteLine("El elemento leído no está en la colección.");
    }
    
    
    // ej 13
    public static void DictadoDeClases(Profesor profesor)
    {
        for (int i = 0; i < 5; i++)
        {
            profesor.HablarALaClase();
            profesor.EscribirEnElPizarron();
        }
    }
    



}
