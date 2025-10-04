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
        
        // ej 9
        Pila pila = new Pila();
        llenarAlumnos(pila);
        cambiarEstrategia(pila, new ComparacionPorNombre());
        Console.WriteLine("Comparando por nombre (alfabeticamente): ");
        informar(pila, "nombre");

        cambiarEstrategia(pila, new ComparacionPorLegajo());
        Console.WriteLine("\nComparando por legajo: ");
        informar(pila, "legajo");


        cambiarEstrategia(pila, new ComparacionPorPromedio());
        Console.WriteLine("\nComparando por promedio: ");
        informar(pila, "promedio");

        cambiarEstrategia(pila, new ComparacionPorDNI());
        Console.WriteLine("\nComparando por dni: ");
        informar(pila, "dni");
        
        
        
        
        
        // ej 2
        // IColeccionable pila = new Pila();
        // IColeccionable cola = new Cola();
        // IColeccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
        // llenarAlumnos(pila);
        // llenarAlumnos(cola);
        //
        // Console.WriteLine("=== INFORME DE LA PILA ===");
        // informar(pila);
        //
        // Console.WriteLine("\n=== INFORME DE LA COLA ===");
        // informar(cola);
        
        
        
        // ej 7
        /*Pila pila = new Pila();
        Cola cola = new Cola();
        Conjunto conjunto = new Conjunto();
    
        llenarAlumnos(pila);
        llenarAlumnos(cola);
        llenarAlumnos(conjunto);
    
        Console.WriteLine("=== ELEMENTOS DE LA PILA ===");
        imprimirElementos(pila);
    
        Console.WriteLine("\n=== ELEMENTOS DE LA COLA ===");
        imprimirElementos(cola);
    
        Console.WriteLine("\n=== ELEMENTOS DEL CONJUNTO ===");
        imprimirElementos(conjunto);*/
    }


    // ej 2
    public static void llenarAlumnos(IColeccionable coleccionable)
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
            
            
            alumno.setEstrategia(new ComparacionPorDNI());  

            coleccionable.agregar(alumno);
        }
    }
    
    public static void llenar(IColeccionable coleccionable)
    {
        for (int i = 0; i < 20; i++){
            IComparable comparable = new Numero(Random.Next(1, 51)); 
            coleccionable.agregar(comparable);
        }
    }
    
    // ej 2
    public static void informar(IColeccionable col)
    {
        Console.WriteLine("Cantidad de elementos: " + col.cuantos().ToString());
        Console.WriteLine("El mínimo es: " + col.minimo().ToString());
        Console.WriteLine("El máximo es: " + col.maximo().ToString());

        Console.WriteLine("Ingrese valor a buscar en el coleccionable: ");
        int valorBuscado = int.Parse(Console.ReadLine()!);

       
        Alumno alumnoBuscado = new Alumno(
            "",
            new Numero(valorBuscado),   // DNI 
            new Numero(0),   // Legajo vacío
            new Numero(0) // Promedio vacio
        );
        alumnoBuscado.setEstrategia(new ComparacionPorPromedio());

        if (col.contiene(alumnoBuscado))
            Console.WriteLine("El elemento leído está en la colección.");
        else
            Console.WriteLine("El elemento leído no está en la colección.");
    }
    
    // ej 9
    static void informar(IColeccionable col, string tipoBusqueda)
    {
        Console.WriteLine("Cantidad de elementos: " + col.cuantos());
        Console.WriteLine("El mínimo es: " + col.minimo());
        Console.WriteLine("El máximo es: " + col.maximo());

        Alumno alumnoBuscado = null;

        switch (tipoBusqueda.ToLower())
        {
            case "nombre":
                Console.Write("Ingrese nombre a buscar: ");
                string nombre = Console.ReadLine() ?? "";
                alumnoBuscado = new Alumno(nombre, new Numero(0), new Numero(0), new Numero(0));
                alumnoBuscado.setEstrategia(new ComparacionPorNombre());
                break;

            case "legajo":
                Console.Write("Ingrese legajo a buscar: ");
                int legajo = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(legajo), new Numero(0));
                alumnoBuscado.setEstrategia(new ComparacionPorLegajo());
                break;

            case "promedio":
                Console.Write("Ingrese promedio a buscar: ");
                int promedio = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(0), new Numero(promedio));
                alumnoBuscado.setEstrategia(new ComparacionPorPromedio());
                break;

            case "dni":
                Console.Write("Ingrese DNI a buscar: ");
                int dni = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(dni), new Numero(0), new Numero(0));
                alumnoBuscado.setEstrategia(new ComparacionPorDNI());
                break;

            default:
                Console.WriteLine("Tipo de búsqueda desconocido.");
                return;
        }

        Console.WriteLine("El valor " + (col.contiene(alumnoBuscado) ? "está" : "no está") + " en la colección.");
    }


    
    // Ejercicio 6
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
    



}
