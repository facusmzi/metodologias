namespace trabajo_integrador
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        // Getter al estilo Java
        public int getValor()
        {
            return this.valor;
        }

        // Setter al estilo Java
        public void setValor(int valor)
        {
            this.valor = valor;
        }

        // Implementamos IComparable
        public bool sosIgual(IComparable comparable)
        {
            return this.valor == ((Numero)comparable).getValor();
        }

        public bool sosMenor(IComparable comparable)
        {
            return this.valor < ((Numero)comparable).getValor();
        }

        public bool sosMayor(IComparable comparable)
        {
            return this.valor > ((Numero)comparable).getValor();
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}