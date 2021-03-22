using System;

namespace _1__clase
{
    class Program
    {
             class Persona
        {
            private string cedula;
            private string nombre;
            private string apellido;
            private string edad;

            public Persona(string cedula, string nombre, string apellido, string edad)
            {
                this.cedula = cedula;
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
            }
            public string Getcedula()
            {
                return cedula;
            }
            public string Getnombre()
            {
                return nombre;
            }
            public string Getapellido()
            {
                return apellido;
            }
            public string Getedad()
            {
                return edad;
            }
        }

        class Estudiante : Persona
        {
            private string matricula;
            private string carrera;


            public Estudiante(string cedula, string nombre, string apellido, string edad, string matricula, string carrera) : base(cedula, nombre, apellido,edad)
            {
                this.matricula = matricula;
                this.carrera = carrera;

            }
            public string Getmatricula()
            {
                return matricula;
            }
            public string Getcarrera()
            {
                return carrera;
            }
        }

        class Prueba
        {
            public static void Main()
            {
                Estudiante op1 = new Estudiante("123789001", "Juan", "Mendoza", "20", "100044974", "Lic. Informatica");
                Estudiante op2 = new Estudiante("001476589002", "Maria", "Camela","19", "100044974", "Ing. Civil");
                MostrarEstudiante(op1);
                MostrarEstudiante(op2);

                Console.ReadKey();
            }
            public static void MostrarEstudiante(Estudiante o)
            {
                System.Console.WriteLine("Cedula {0}  Nombre {1}  Apellido {2} edad{1} Matricula {3}  Carrera {4}", o.Getcedula(), o.Getnombre(), o.Getapellido(), o.Getedad(), o.Getmatricula(), o.Getcarrera());
            }
        }

    }
}

