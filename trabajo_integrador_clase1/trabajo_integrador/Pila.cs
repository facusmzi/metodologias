namespace trabajo_integrador
{
    public class Pila : IColeccionable
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

            return elementos[elementos.Count - 1];
        }

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
            if (vacia())
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
            apilar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i].sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
