namespace trabajo_integrador
{
    public class ComparacionPorNombre : IEstrategiaComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return alumnoA.getNombre() == alumnoB.getNombre();
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return string.Compare(alumnoA.getNombre(), alumnoB.getNombre(), StringComparison.Ordinal) < 0;
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return string.Compare(alumnoA.getNombre(), alumnoB.getNombre(), StringComparison.Ordinal) > 0;
        }
    }
}