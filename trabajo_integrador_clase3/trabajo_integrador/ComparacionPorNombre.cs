namespace trabajo_integrador
{
    public class ComparacionPorNombre : IEstrategiaComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getNombre() == alumnoB.getNombre();
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return string.Compare(alumnoA.getNombre(), alumnoB.getNombre(), StringComparison.Ordinal) < 0;
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return string.Compare(alumnoA.getNombre(), alumnoB.getNombre(), StringComparison.Ordinal) > 0;
        }
    }
}