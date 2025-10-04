namespace trabajo_integrador
{
    public abstract class Persona : IComparable
    {
        protected string nombre;
        protected Numero dni;

        public Persona(string n, Numero d)
        {
            nombre = n;
            dni = d;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public Numero getDni()
        {
            return dni;
        }

        public void setDni(Numero d)
        {
            dni = d;
        }

        public virtual bool sosIgual(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return this.dni.sosIgual(persona.getDni());
        }

        public virtual bool sosMenor(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return this.dni.sosMenor(persona.getDni());
        }

        public virtual bool sosMayor(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return this.dni.sosMayor(persona.getDni());
        }
    }
}