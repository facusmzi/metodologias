namespace trabajo_integrador
{
    public class Conjunto : IColeccionable, IIterable
    {
        private List<IComparable> elementosComparables;

        public Conjunto()
        {
            this.elementosComparables = new List<IComparable>();
        }

        public void agregar(IComparable comparable)
        {
            if (!pertenece(comparable))
            {
                elementosComparables.Add(comparable);
            }
        }

        public bool pertenece(IComparable comparable)
        {
            for (int i = 0; i < this.elementosComparables.Count; i++)
            {
                if (this.elementosComparables[i].sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return elementosComparables.Count;
        }

        public IComparable minimo()
        {
            if (elementosComparables.Count == 0)
            {
                return null;
            }

            IComparable minimo = this.elementosComparables[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (this.elementosComparables[i].sosMenor(minimo))
                {
                    minimo = this.elementosComparables[i];
                }
            }
            return minimo;
        }

        public IComparable maximo()
        {
            if (elementosComparables.Count == 0)
            {
                return null;
            }

            IComparable maximo = this.elementosComparables[0];

            for (int i = 1; i < this.cuantos(); i++)
            {
                if (this.elementosComparables[i].sosMayor(maximo))
                {
                    maximo = this.elementosComparables[i];
                }
            }
            return maximo;
        }

        public bool contiene(IComparable comparable)
        {
            return pertenece(comparable);
        }

        public IIterador crearIterador()
        {
            return new IteradorDeLista(elementosComparables);
        }
    }
}
