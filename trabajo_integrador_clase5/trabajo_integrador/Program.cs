using MetodologíasDeProgramaciónI;

namespace trabajo_integrador;

class Program
{

    
    static void Main(string[] args)
    {
        
        // ej 10
        Cola cola = new Cola();
        Aula aulaCola = new Aula();
        cola.setOrdenInicio(new OrdenInicio(aulaCola));
        cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aulaCola));
        cola.setOrdenAulaLlena(new OrdenAulaLlena(aulaCola));
			     
        llenar(cola, 2); // 20 alumnos normales
        llenar(cola, 4); // 20 alumnos muy estudiosos
        
        
        
        // ej 2
        /*DecoradorNumeroOrden.resetearContador();

        Teacher teacher = new Teacher();


        for (int i = 0; i < 10; i++)
        {
            IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
            alumno.setEstrategia(new ComparacionPorCalificacion());
            

            IAlumno alumnoDecorado = alumno;
            alumnoDecorado = new DecoradorLegajo(alumnoDecorado);
            alumnoDecorado = new DecoradorNotaEnLetras(alumnoDecorado);
            alumnoDecorado = new DecoradorEstado(alumnoDecorado);
            alumnoDecorado = new DecoradorNumeroOrden(alumnoDecorado);
            alumnoDecorado = new DecoradorRecuadro(alumnoDecorado);

            Student student = new AlumnoAdapter(alumnoDecorado);
            teacher.goToClass(student);
        }
        
        for (int i = 0; i < 10; i++)
        {
            string nombre = GeneradorDeDatosAleatorios.stringAleatorio(8);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(45000000) + 20000000;
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999) + 1000;
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);

            AlumnoMuyEstudioso estudioso = new AlumnoMuyEstudioso(
                nombre,
                new Numero(dni),
                new Numero(legajo),
                new Numero(promedio)
            );

            estudioso.setEstrategia(new ComparacionPorCalificacion());
            
            IAlumno alumnoDecorado = estudioso;
            alumnoDecorado = new DecoradorLegajo(alumnoDecorado);
            alumnoDecorado = new DecoradorNotaEnLetras(alumnoDecorado);
            alumnoDecorado = new DecoradorEstado(alumnoDecorado);
            alumnoDecorado = new DecoradorNumeroOrden(alumnoDecorado);
            alumnoDecorado = new DecoradorRecuadro(alumnoDecorado);

            Student student = new AlumnoAdapter(alumnoDecorado);
            teacher.goToClass(student);
        }
        
        teacher.teachingAClass();*/
        
    }
    
    public static void llenar(IColeccionable coleccionable, int opcion)
    {
        for (int i = 0; i < 20; i++)
        {
            IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
            coleccionable.agregar(comparable);
        }
    }
    


}
