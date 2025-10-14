namespace trabajo_integrador;

public class OrdenLlegaAlumno : IOrdenEnAula2
{
    private Aula aula;
        
    public OrdenLlegaAlumno(Aula aula)
    {
        this.aula = aula;
    }
        
    public void ejecutar(IComparable comparable)
    {
        IAlumno alumno = (IAlumno)comparable;
        aula.nuevoAlumno(alumno);
    }
}