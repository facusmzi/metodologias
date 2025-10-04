namespace trabajo_integrador
{
    public class Cola : IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Cola()
        {
            this.elementos = new List<IComparable>();
        }

        // Getter y setter al estilo Java para elementos
        public List<IComparable> getElementos()
        {
            return elementos;
        }

        public void setElementos(List<IComparable> e)
        {
            elementos = e;
        }

        public void encolar(IComparable elem)
        {
            elementos.Add(elem);
        }

        public IComparable desencolar()
        {
            if (this.vacia())
            {
                return null;
            }

            IComparable aux = elementos[0];
            elementos.RemoveAt(0);
            return aux;
        }

        public bool vacia()
        {
            return elementos.Count == 0;
        }

        public IComparable tope()
        {
            if (this.vacia())
                return null;

            return elementos[0];
        }

        // Implementación de IColeccionable
        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable minimo()
        {
            if (this.vacia())
                return null;

            IComparable min = elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                IComparable actual = elementos[i];
                if (actual.sosMenor(min))
                {
                    min = actual;
                }
            }
            return min;
        }

        public IComparable maximo()
        {
            if (this.vacia())
                return null;

            IComparable max = elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                IComparable actual = elementos[i];
                if (actual.sosMayor(max))
                {
                    max = actual;
                }
            }
            return max;
        }

        public void agregar(IComparable comparable)
        {
            encolar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                IComparable actual = elementos[i];
                if (actual.sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterador crearIterador()
        {
            return new IteradorDeLista(elementos);
        }
    }
}
