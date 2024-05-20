using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaP2
{
    internal class @base
    {
        // Clase base o clase principal
        public class MiembroDeLaComunidad
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Rol { get; set; }

            public MiembroDeLaComunidad(string nombre, int edad, string rol)
            {
                Nombre = nombre;
                Edad = edad;
                Rol = rol;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Rol: {Rol}");
            }
        }

        // Subclase de la clase principal miembrosdelacomunidad
        public class Empleado : MiembroDeLaComunidad
        {
            public int IdEmpleado { get; set; }

            public Empleado(string nombre, int edad, int idEmpleado)
                : base(nombre, edad, "Empleado")
            {
                IdEmpleado = idEmpleado;
            }
        }

        // subclase estudiante la cual viene de miembros de la comunidad
        public class Estudiante : MiembroDeLaComunidad
        {
            public string NumeroMatricula { get; set; }

            public Estudiante(string nombre, int edad, string numeroMatricula)
                : base(nombre, edad, "Estudiante")
            {
                NumeroMatricula = numeroMatricula;
            }
        }

        // Subclase exAlumno de MiembroDeLaComunidad
        public class ExAlumno : MiembroDeLaComunidad
        {
            public int AñoGraduacion { get; set; }

            public ExAlumno(string nombre, int edad, int añoGraduacion)
                : base(nombre, edad, "ExAlumno")
            {
                AñoGraduacion = añoGraduacion;
            }
        }

        // Subclase docente la cual viene de la subclase Empleado 
        public class Docente : Empleado
        {
            public string Materia { get; set; }

            public Docente(string nombre, int edad, int idEmpleado, string materia)
                : base(nombre, edad, idEmpleado)
            {
                Materia = materia;
                Rol = "Docente";
            }
        }

        // Subclase Administrativo de Empleado
        public class Administrativo : Empleado
        {
            public string Departamento { get; set; }

            public Administrativo(string nombre, int edad, int idEmpleado, string departamento)
                : base(nombre, edad, idEmpleado)
            {
                Departamento = departamento;
                Rol = "Administrativo";
            }
        }

        // Subclase Administrador de Docente
        public class Administrador : Docente
        {
            public string AreaAdministrativa { get; set; }

            public Administrador(string nombre, int edad, int idEmpleado, string materia, string areaAdministrativa)
                : base(nombre, edad, idEmpleado, materia)
            {
                AreaAdministrativa = areaAdministrativa;
                Rol = "Administrador";
            }
        }

        // Subclase Maestro de Docente
        public class Maestro : Docente
        {
            public int AñosExperiencia { get; set; }

            public Maestro(string nombre, int edad, int idEmpleado, string materia, int añosExperiencia)
                : base(nombre, edad, idEmpleado, materia)
            {
                AñosExperiencia = añosExperiencia;
                Rol = "Maestro";
            }
        }
    }
}