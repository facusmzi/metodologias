namespace trabajo_integrador
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        // Getter y setter "manuales" en minúscula
        public int getValor()
        {
            return valor;
        }

        public void setValor(int valor)
        {
            this.valor = valor;
        }

        // Implementamos la interfaz IComparable
        public bool sosIgual(IComparable comparable)
        {
            return this.valor == ((Numero)comparable).valor;
        }

        public bool sosMenor(IComparable comparable)
        {
            return this.valor < ((Numero)comparable).valor;
        }

        public bool sosMayor(IComparable comparable)
        {
            return this.valor > ((Numero)comparable).valor;
        }

        // override de ToString
        public override string ToString()
        {
            return valor.ToString();
        }
    }
}