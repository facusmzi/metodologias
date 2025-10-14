using MetodologíasDeProgramaciónI;

namespace trabajo_integrador;

public class Aula
{
    private Teacher teacher;
    
    public void comenzar()
    {
        Console.WriteLine("=== Comienza la clase ===");
        teacher = new Teacher();
    }
        
    public void nuevoAlumno(IAlumno alumno)
    {
        Student student = new AlumnoAdapter(alumno);
        teacher.goToClass(student);
    }
        
    public void claseLista()
    {
        Console.WriteLine("=== El aula está lista, comienza la enseñanza ===");
        teacher.teachingAClass();
    }
}