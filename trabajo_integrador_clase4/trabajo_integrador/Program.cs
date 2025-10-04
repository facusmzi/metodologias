using MetodologíasDeProgramaciónI;

namespace trabajo_integrador;

class Program
{

    
    static void Main(string[] args)
    {
        FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();


        Teacher teacher = new Teacher();

        // Crear 10 alumnos normales y adaptarlos
        for (int i = 0; i < 10; i++)
        {
            Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);

            // Asignamos la estrategia de comparación por calificación
            alumno.setEstrategia(new ComparacionPorCalificacion());

            Student student = new AlumnoAdapter(alumno);
            teacher.goToClass(student);
        }

        
        Random rnd = new Random();
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

            // Asignamos la estrategia de comparación por calificación
            estudioso.setEstrategia(new ComparacionPorCalificacion());

            Student student = new AlumnoAdapter(estudioso);
            teacher.goToClass(student);
        }


        teacher.teachingAClass();
        
    }
    
    
    


}
