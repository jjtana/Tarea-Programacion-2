using static TareaP2.@base;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        //aqui instanciamos cada una de nuestras clases

        MiembroDeLaComunidad miembro = new MiembroDeLaComunidad("Jostin Wilmer Perez", 50, "Miembro de la Comunidad");
        Empleado empleado = new Empleado("Francis Ramirez", 40, 2222);
        Estudiante estudiante = new Estudiante("Abinader Hermandez", 20, "ABC555");
        ExAlumno exAlumno = new ExAlumno("Kenia Santana", 25, 2020);
        Docente docente = new Docente("Leonel Fernandez", 55, 3333, "Matemáticas");
        Administrativo administrativo = new Administrativo("Melvin De La cruz", 44, 4444, "Encargado de seguridad");
        Administrador administrador = new Administrador("Eladio Ruiz", 53, 5555, "Programacion", "Decano");
        Maestro maestro = new Maestro("Juan Perez Perez", 46, 6666, "Informatica", 15);

        // Mostramos la informacion de cada una de nuestras clases y subclases
        miembro.MostrarInformacion();
        empleado.MostrarInformacion();
        estudiante.MostrarInformacion();
        exAlumno.MostrarInformacion();
        docente.MostrarInformacion();
        administrativo.MostrarInformacion();
        administrador.MostrarInformacion();
        maestro.MostrarInformacion();

    }
}