namespace trabajo_integrador
{
    public class Pila : IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Pila()
        {
            elementos = new List<IComparable>();
        }

        public void apilar(IComparable elem)
        {
            elementos.Add(elem);
        }

        public IComparable desapilar()
        {
            if (vacia())
                return null;

            int tam = elementos.Count;
            IComparable aux = elementos[tam - 1];
            elementos.RemoveAt(tam - 1);
            return aux;
        }

        public bool vacia()
        {
            return elementos.Count == 0;
        }

        public IComparable tope()
        {
            if (vacia())
                return null;

            int tam = elementos.Count;
            return elementos[tam - 1];
        }

        // Implementación de IColeccionable
        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable minimo()
        {
            if (vacia())
                return null;

            IComparable min = elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMenor(min))
                    min = elementos[i];
            }
            return min;
        }

        public IComparable maximo()
        {
            if (vacia())
                return null;

            IComparable max = elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMayor(max))
                    max = elementos[i];
            }
            return max;
        }

        public void agregar(IComparable comparable)
        {
            apilar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            foreach (var actual in elementos)
            {
                if (actual.sosIgual(comparable))
                    return true;
            }
            return false;
        }

        public IIterador crearIterador()
        {
            return new IteradorDeLista(elementos);
        }
    }
}
