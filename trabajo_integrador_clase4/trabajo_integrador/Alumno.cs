namespace trabajo_integrador
{
    public class Alumno : Persona, IObservador, IAlumno
    {
        private Numero legajo;
        private Numero promedio;
        private IEstrategiaComparacion estrategia;
        private int calificacion;

        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            legajo = l;
            promedio = p;
            estrategia = new ComparacionPorLegajo();
            calificacion = 0;
        }

        // Getters y setters como métodos
        public Numero getLegajo()
        {
            return legajo;
        }

        public Numero getPromedio()
        {
            return promedio;
        }

        public IEstrategiaComparacion getEstrategia()
        {
            return estrategia;
        }

        public void setEstrategia(IEstrategiaComparacion e)
        {
            estrategia = e;
        }

        public int getCalificacion()
        {
            return calificacion;
        }

        public void setCalificacion(int c)
        {
            calificacion = c;
        }

        // Métodos heredados / override
        public override string ToString()
        {
            return $"{nombre} (DNI: {dni}, Legajo: {legajo}, Promedio: {promedio})";
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

        // IObservador
        public void prestarAtencion()
        {
            Console.WriteLine($"  {nombre}: Prestando atención");
        }

        public void distraerse()
        {
            Random random = new Random();
            string[] distracciones = {
                "Mirando el celular",
                "Dibujando en el margen de la carpeta",
                "Tirando aviones de papel"
            };

            int indice = random.Next(distracciones.Length);
            Console.WriteLine($"  {nombre}: {distracciones[indice]}");
        }

        public void actualizar(IObservado observado)
        {
            Profesor profesor = (Profesor)observado;

            if (profesor.getUltimaAccion() == "hablar")
            {
                prestarAtencion();
            }
            else if (profesor.getUltimaAccion() == "escribir")
            {
                distraerse();
            }
        }

        // Ej 1
        public virtual int responderPregunta(int pregunta)
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public string mostrarCalificacion()
        {
            return $"{nombre} {calificacion}";
        }
    }
}
