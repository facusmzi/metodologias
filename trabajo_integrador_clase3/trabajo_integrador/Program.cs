namespace trabajo_integrador;

class Program
{

    private static Random Random = new Random();

    // Arrays para generar nombres aleatorios
    private static string[] nombres = {
        "Juan", "María", "Carlos", "Ana", "Luis", "Carmen", "Pedro", "Laura",
        "Miguel", "Sofia", "Diego", "Valeria", "Pablo", "Gabriela", "Andrés",
        "Camila", "Sebastián", "Martina", "Federico", "Agustina"
    };

    private static string[] apellidos = {
        "González", "Rodríguez", "Pérez", "López", "Martínez", "García",
        "Fernández", "Álvarez", "Romero", "Suárez", "Torres", "Ruiz",
        "Ramírez", "Flores", "Benítez", "Medina", "Herrera", "Castillo",
        "Morales", "Ortega"
    };


    static void Main(string[] args)
    {
        
        
        Pila pila = new Pila();
        LlenarAlumnos(pila);
        CambiarEstrategia(pila, new ComparacionPorNombre());
        Console.WriteLine("Comparando por nombre (alfabeticamente): ");
        Informar(pila, "nombre");

        CambiarEstrategia(pila, new ComparacionPorLegajo());
        Console.WriteLine("\nComparando por legajo: ");
        Informar(pila, "legajo");


        CambiarEstrategia(pila, new ComparacionPorPromedio());
        Console.WriteLine("\nComparando por promedio: ");
        Informar(pila, "promedio");

        CambiarEstrategia(pila, new ComparacionPorDNI());
        Console.WriteLine("\nComparando por dni: ");
        Informar(pila, "dni");
        
        
        
        // // Crear profesor aleatorio
        // IComparable prof = FabricaDeComparables.CrearAleatorio(3);
        //
        // // Llenar una pila con profesores
        // Pila pila = new Pila();
        // Llenar(pila, 3);
        // Informar(pila, 3);
        //
        
        
    }


    
    public static void LlenarAlumnos(IColeccionable coleccionable)
    {
        for (int i = 0; i < 20; i++)
        {
            string nombreAlAzar = nombres[Random.Next(nombres.Length)];
            int dniAlAzar = Random.Next(20000000, 45000000);
            int legajoAlAzar = Random.Next(1000, 9999);
            int promedioAlAzar = Random.Next(0, 11);

            Alumno alumno = new Alumno(
                nombreAlAzar,
                new Numero(dniAlAzar),
                new Numero(legajoAlAzar),
                new Numero(promedioAlAzar)
            );
            
            
            alumno.Estrategia = new ComparacionPorDNI();

            coleccionable.Agregar(alumno);
        }
    }
    
    

    
    /*static void Informar(IColeccionable col, string tipoBusqueda)
    {
        Console.WriteLine("Cantidad de elementos: " + col.Cuantos());
        Console.WriteLine("El mínimo es: " + col.Minimo());
        Console.WriteLine("El máximo es: " + col.Maximo());

        Alumno alumnoBuscado = null;

        switch (tipoBusqueda.ToLower())
        {
            case "nombre":
                Console.Write("Ingrese nombre a buscar: ");
                string nombre = Console.ReadLine() ?? "";
                alumnoBuscado = new Alumno(nombre, new Numero(0), new Numero(0), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorNombre();
                break;

            case "legajo":
                Console.Write("Ingrese legajo a buscar: ");
                int legajo = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(legajo), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorLegajo();
                break;

            case "promedio":
                Console.Write("Ingrese promedio a buscar: ");
                int promedio = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(0), new Numero(promedio));
                alumnoBuscado.Estrategia = new ComparacionPorPromedio();
                break;

            case "dni":
                Console.Write("Ingrese DNI a buscar: ");
                int dni = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(dni), new Numero(0), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorDNI();
                break;

            default:
                Console.WriteLine("Tipo de búsqueda desconocido.");
                return;
        }

        Console.WriteLine("El valor " + (col.Contiene(alumnoBuscado) ? "está" : "no está") + " en la colección.");
    }*/


    
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
    



}
