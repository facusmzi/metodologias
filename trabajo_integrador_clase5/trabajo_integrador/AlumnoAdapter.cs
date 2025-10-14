using MetodologíasDeProgramaciónI;

namespace trabajo_integrador
{
    public class AlumnoAdapter : Student
    {
        protected IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        // Método para acceder al alumno
        public IAlumno getAlumno()
        {
            return alumno;
        }

        // Implemento los métodos de Student

        public string getName()
        {
            return alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            IAlumno stu = ((AlumnoAdapter)student).getAlumno();
            return alumno.sosIgual(stu);
        }

        public bool lessThan(Student student)
        {
            IAlumno stu = ((AlumnoAdapter)student).getAlumno();
            return alumno.sosMenor(stu);
        }

        public bool greaterThan(Student student)
        {
            IAlumno stu = ((AlumnoAdapter)student).getAlumno();
            return alumno.sosMayor(stu);
        }
    }
}