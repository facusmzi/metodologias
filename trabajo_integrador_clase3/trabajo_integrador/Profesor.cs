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

        // Getters y setters normales
        public Numero getAntiguedad()
        {
            return antiguedad;
        }

        public void setAntiguedad(Numero a)
        {
            antiguedad = a;
        }

        public string getUltimaAccion()
        {
            return ultimaAccion;
        }

        public void setUltimaAccion(string accion)
        {
            ultimaAccion = accion;
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
            return this.antiguedad.sosIgual(otro.getAntiguedad());
        }

        public override bool sosMenor(IComparable comparable)
        {
            Profesor otro = (Profesor)comparable;
            return this.antiguedad.sosMenor(otro.getAntiguedad());
        }

        public override bool sosMayor(IComparable comparable)
        {
            Profesor otro = (Profesor)comparable;
            return this.antiguedad.sosMayor(otro.getAntiguedad());
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
