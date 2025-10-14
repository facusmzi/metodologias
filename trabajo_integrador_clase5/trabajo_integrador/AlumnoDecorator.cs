namespace trabajo_integrador;

public abstract class AlumnoDecorator : IAlumno
{
		
    protected IAlumno alumnoAdicional;
		
    public AlumnoDecorator(IAlumno alumno)
    {
        this.alumnoAdicional = alumno;
    }
		
    public string getNombre()
    {
        return alumnoAdicional.getNombre();
    }
		
    public Numero getDni()
    {
        return alumnoAdicional.getDni();
    }
    
    public void setNombre(string n)
    {
        alumnoAdicional.setNombre(n);
    }
		
    public bool sosIgual(IComparable comp)
    {
        return this.alumnoAdicional.sosIgual(comp);
    }
	
    public bool sosMenor(IComparable comp)
    {
        return this.alumnoAdicional.sosMenor(comp);
    }
	
    public bool sosMayor(IComparable comp)
    {
        return this.alumnoAdicional.sosMayor(comp);
    }
				
		
    public Numero getLegajo()
    {
        return this.alumnoAdicional.getLegajo();
    }

    public IEstrategiaComparacion getEstrategia()
    {
        return this.alumnoAdicional.getEstrategia();
    }
		
    public Numero getPromedio()
    {
        return this.alumnoAdicional.getPromedio();
    }

	    
    public int getCalificacion()
    {
        return this.alumnoAdicional.getCalificacion();
    }

	    
    public void setCalificacion(int calificacion)
    {
        this.alumnoAdicional.setCalificacion(calificacion);
    }

	    
    public void setEstrategia (IEstrategiaComparacion estrategia)
    {
        this.alumnoAdicional.setEstrategia(estrategia);
    }
  	
	    	    
    public void prestarAtencion()
    {
        this.alumnoAdicional.prestarAtencion();
    }

	    	    
    public void distraerse()
    {
        this.alumnoAdicional.distraerse();
    }

	    	    
    public void actualizar(IObservado o)
    {
        this.alumnoAdicional.actualizar(o);
    }

	    	    
    public int responderPregunta(int pregunta)
    {
        return this.alumnoAdicional.responderPregunta(pregunta);
    }

	    	    
    public virtual string mostrarCalificacion(){
        return this.alumnoAdicional.mostrarCalificacion();
    }
    
		
}