namespace trabajo_integrador
{
    public class ColeccionMultiple : IColeccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable minimo()
        {
            if (pila.cuantos() == 0 && cola.cuantos() == 0)
                throw new InvalidOperationException("Ambas colecciones están vacías");

            if (pila.cuantos() == 0)
                return cola.minimo();
            if (cola.cuantos() == 0)
                return pila.minimo();

            IComparable minPila = pila.minimo();
            IComparable minCola = cola.minimo();

            if (minPila.sosMenor(minCola))
                return minPila;
            else
                return minCola;
        }

        public IComparable maximo()
        {
            if (pila.cuantos() == 0 && cola.cuantos() == 0)
                throw new InvalidOperationException("Ambas colecciones están vacías");

            if (pila.cuantos() == 0)
                return cola.maximo();
            if (cola.cuantos() == 0)
                return pila.maximo();

            IComparable maxPila = pila.maximo();
            IComparable maxCola = cola.maximo();

            if (maxPila.sosMayor(maxCola))
                return maxPila;
            else
                return maxCola;
        }

        public void agregar(IComparable comparable)
        {
            // Según tu implementación original, no hace nada.
            // Podrías definir una política, por ejemplo agregar a pila por defecto:
            pila.agregar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            return pila.contiene(comparable) || cola.contiene(comparable);
        }
    }
}