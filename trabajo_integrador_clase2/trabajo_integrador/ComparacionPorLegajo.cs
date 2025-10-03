namespace trabajo_integrador;

public class ComparacionPorLegajo : IEstrategiaComparacion
{
    public bool SosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Legajo.SosIgual(alumnoB.Legajo);
    }

    public bool SosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Legajo.SosMenor(alumnoB.Legajo);
    }

    public bool SosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Legajo.SosMayor(alumnoB.Legajo);
    }
}