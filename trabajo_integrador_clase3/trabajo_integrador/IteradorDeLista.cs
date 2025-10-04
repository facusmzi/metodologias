namespace trabajo_integrador
{
    public class IteradorDeLista : IIterador
    {
        private List<IComparable> elementos;
        private int posicionActual;

        public IteradorDeLista(List<IComparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }

        public bool fin()
        {
            return posicionActual >= elementos.Count;
        }

        public IComparable actual()
        {
            return elementos[posicionActual];
        }
    }
}