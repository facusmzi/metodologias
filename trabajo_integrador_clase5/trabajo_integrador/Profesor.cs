namespace trabajo_integrador
{
    public class Profesor : Persona, IObservado
    {
        private Numero antiguedad;
        private List<IObservador> observadores;
        private string ultimaAccion;

        public Profesor(string n, Numero d, Numero a) : base(n, d)
        {
            antiguedad = a;
            observadores = new List<IObservador>();
            ultimaAccion = "";
        }

        public Numero getAntiguedad()
        {
            return antiguedad;
        }

        public string getUltimaAccion()
        {
            return ultimaAccion;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            ultimaAccion = "hablar";
            notificar();
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            ultimaAccion = "escribir";
            notificar();
        }

        public override bool sosIgual(IComparable comparable)
        {
            Profesor otro = (Profesor)comparable;
            return antiguedad.sosIgual(otro.antiguedad);
        }

        public override bool sosMenor(IComparable comparable)
        {
            Profesor otro = (Profesor)comparable;
            return antiguedad.sosMenor(otro.antiguedad);
        }

        public override bool sosMayor(IComparable comparable)
        {
            Profesor otro = (Profesor)comparable;
            return antiguedad.sosMayor(otro.antiguedad);
        }

        public override string ToString()
        {
            return $"{nombre} (DNI: {dni}, Antigüedad: {antiguedad} años)";
        }

        // IObservado
        public void agregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (IObservador observador in observadores)
            {
                observador.actualizar(this);
            }
        }
    }
}
