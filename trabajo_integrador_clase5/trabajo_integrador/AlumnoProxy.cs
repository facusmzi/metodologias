namespace trabajo_integrador
{
    public class AlumnoProxy : IAlumno
    {
        private IAlumno alumnoReal;
        private string nombreProxy;
        private int opcion;
        private IEstrategiaComparacion estrategiaGuardada; 
        
        public AlumnoProxy(string nombre, int opcion)
        {
            this.nombreProxy = nombre;
            this.opcion = opcion;
            this.alumnoReal = null;
            this.estrategiaGuardada = null;
        }
        
        private void CrearAlumnoReal()
        {
            Console.WriteLine($"\n>>> ⭐ PROXY: Se creó el alumno real '{nombreProxy}' ⭐ <<<\n");
            
            alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(opcion);
            alumnoReal.setNombre(nombreProxy);
            
            if (estrategiaGuardada != null)
            {
                alumnoReal.setEstrategia(estrategiaGuardada);
            }
            
        }
        
        public string getNombre()
        {
            return nombreProxy;
        }

        public void setNombre(string nombre)
        {
            nombreProxy = nombre;
            if (alumnoReal != null)
            {
                alumnoReal.setNombre(nombre);
            }
        }
        
        
        public void setEstrategia(IEstrategiaComparacion estrategia)
        {
            estrategiaGuardada = estrategia;
            
            if (alumnoReal != null)
            {
                alumnoReal.setEstrategia(estrategia);
            }
        }
        
        public IEstrategiaComparacion getEstrategia()
        {
            if (alumnoReal == null)
            {
                return estrategiaGuardada; 
            }
            return alumnoReal.getEstrategia();
        }
        
        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                CrearAlumnoReal();
            }
            return alumnoReal.responderPregunta(pregunta);
        }
        
        
        public Numero getLegajo()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.getLegajo();
        }
        
        public Numero getDni()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.getDni();
        }
        
        public Numero getPromedio()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.getPromedio();
        }
        
        public int getCalificacion()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.getCalificacion();
        }
        
        public void setCalificacion(int calificacion)
        {
            if (alumnoReal == null) CrearAlumnoReal();
            alumnoReal.setCalificacion(calificacion);
        }
        
        public void prestarAtencion()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            alumnoReal.prestarAtencion();
        }
        
        public void distraerse()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            alumnoReal.distraerse();
        }
        
        public void actualizar(IObservado observado)
        {
            if (alumnoReal == null) CrearAlumnoReal();
            alumnoReal.actualizar(observado);
        }
        
        public string mostrarCalificacion()
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.mostrarCalificacion();
        }
        
        public bool sosIgual(IComparable comparable)
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.sosIgual(comparable);
        }
        
        public bool sosMenor(IComparable comparable)
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.sosMenor(comparable);
        }
        
        public bool sosMayor(IComparable comparable)
        {
            if (alumnoReal == null) CrearAlumnoReal();
            return alumnoReal.sosMayor(comparable);
        }
    }
}