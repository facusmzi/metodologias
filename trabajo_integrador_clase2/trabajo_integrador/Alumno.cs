namespace trabajo_integrador
{
    public class Alumno : Persona
    {
        private Numero legajo;
        private Numero promedio;
        private IEstrategiaComparacion estrategia;

        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            legajo = l;
            promedio = p;
            estrategia = new ComparacionPorLegajo();
        }

        // Getters y setters al estilo Java
        public Numero getLegajo()
        {
            return legajo;
        }

        public void setLegajo(Numero l)
        {
            legajo = l;
        }

        public Numero getPromedio()
        {
            return promedio;
        }

        public void setPromedio(Numero p)
        {
            promedio = p;
        }

        public IEstrategiaComparacion getEstrategia()
        {
            return estrategia;
        }

        public void setEstrategia(IEstrategiaComparacion e)
        {
            estrategia = e;
        }

        public override string ToString()
        {
            return $"{getNombre()} (DNI: {getDni()}, Legajo: {legajo.getValor()}, Promedio: {promedio.getValor()})";
        }

        public override bool sosIgual(IComparable comparable)
        {
            return estrategia.sosIgual(this, comparable);
        }

        public override bool sosMenor(IComparable comparable)
        {
            return estrategia.sosMenor(this, comparable);
        }

        public override bool sosMayor(IComparable comparable)
        {
            return estrategia.sosMayor(this, comparable);
        }
    }
}