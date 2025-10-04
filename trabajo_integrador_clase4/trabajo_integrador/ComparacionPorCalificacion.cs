namespace trabajo_integrador;

public class ComparacionPorCalificacion : IEstrategiaComparacion
{
    public bool sosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getCalificacion() == alumnoB.getCalificacion();
    }

    public bool sosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getCalificacion() < alumnoB.getCalificacion();
    }

    public bool sosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getCalificacion() > alumnoB.getCalificacion();
    }
}