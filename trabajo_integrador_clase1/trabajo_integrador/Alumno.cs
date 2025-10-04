namespace trabajo_integrador
{
    public class Alumno : Persona
    {
        private Numero legajo;
        private Numero promedio;

        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }
        
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

        public override string ToString()
        {
            return nombre + " (DNI: " + dni + ", Legajo: " + legajo + ", Promedio: " + promedio + ")";
        }

        public override bool sosIgual(IComparable comparable)
        {
            Numero otro = (Numero)comparable;
            return this.legajo.sosIgual(comparable);
        }

        public override bool sosMenor(IComparable comparable)
        {
            Alumno otro = (Alumno)comparable;
            return this.legajo.sosMenor(otro.getLegajo());
        }

        public override bool sosMayor(IComparable comparable)
        {
            Alumno otro = (Alumno)comparable;
            return this.legajo.sosMayor(otro.getLegajo());
        }
    }
}