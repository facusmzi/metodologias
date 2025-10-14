namespace trabajo_integrador
{
    public class Pila : IColeccionable, IIterable, IOrdenable
    {
        private List<IComparable> elementos;
        
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;

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

        // ej 9
        public void agregar(IComparable comparable)
        {
            // 1. Si es el primer elemento ejecutar orden de inicio
            if (cuantos() == 0 && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }
            
            // 2 Agregar el elemento a la pila
            apilar(comparable);
            
            // 3 Ejecutar orden de llegada de alumno
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(comparable);
            }
            
            // 4 Si alcanzamos 40 elementos ejecutar orden aula llena
            if (cuantos() == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
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
        
        // IOrdenable
        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }
        
        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }
        
        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}