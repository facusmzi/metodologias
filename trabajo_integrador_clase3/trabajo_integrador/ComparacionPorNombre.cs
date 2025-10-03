namespace trabajo_integrador;

public class ComparacionPorNombre : IEstrategiaComparacion
{
    public bool SosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Nombre == alumnoB.Nombre;
    }

    public bool SosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return string.Compare(alumnoA.Nombre, alumnoB.Nombre, StringComparison.Ordinal) < 0;
    }

    public bool SosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return string.Compare(alumnoA.Nombre, alumnoB.Nombre, StringComparison.Ordinal) > 0;
    }
}