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

        public Numero getDni()
        {
            return dni;
        }

        public virtual bool sosIgual(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return dni.sosIgual(persona.dni);
        }

        public virtual bool sosMenor(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return dni.sosMenor(persona.dni);
        }

        public virtual bool sosMayor(IComparable comparable)
        {
            Persona persona = (Persona)comparable;
            return dni.sosMayor(persona.dni);
        }
    }
}