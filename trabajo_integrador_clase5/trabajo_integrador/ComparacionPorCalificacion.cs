namespace trabajo_integrador;

public class ComparacionPorCalificacion : IEstrategiaComparacion
{
    public bool sosIgual(IComparable a, IComparable b)
    {
        IAlumno alumnoA = (IAlumno)a;
        IAlumno alumnoB = (IAlumno)b;
        return alumnoA.getCalificacion() == alumnoB.getCalificacion();
    }

    public bool sosMenor(IComparable a, IComparable b)
    {
        IAlumno alumnoA = (IAlumno)a;
        IAlumno alumnoB = (IAlumno)b;
        return alumnoA.getCalificacion() < alumnoB.getCalificacion();
    }

    public bool sosMayor(IComparable a, IComparable b)
    {
        IAlumno alumnoA = (IAlumno)a;
        IAlumno alumnoB = (IAlumno)b;
        return alumnoA.getCalificacion() > alumnoB.getCalificacion();
    }
}