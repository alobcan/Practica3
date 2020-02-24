using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            List<Materia> materias = new List<Materia>();
            List<Nota> notas = new List<Nota>();
            List<Carrera> carreras = new List<Carrera>();

            //Inicializamos carreras, estudiantes, materias y notas para probar
            //el programa de manera mas eficiente.
            Carreras_Seeder(carreras);
            Estudiantes_Seeder(estudiantes);
            Materias_Seeder(materias);
            Notas_Seeder(notas);


            Menu_1(estudiantes, notas, materias, carreras);
            Fin_Programa();
        }

        private static void Fin_Programa()
        {
            Console.Clear();
            Console.WriteLine("Gracias, presione 'enter' para terminar...");
            Console.ReadKey();
        }

        private static void Notas_Seeder(List<Nota> notas)
        {
            Nota nota1 = new Nota() { CiEstudiante = 7913188, Idmateria = 21, NotaFinal = 95 };
            Nota nota2 = new Nota() { CiEstudiante = 1234, Idmateria = 21, NotaFinal = 65 };
            Nota nota3 = new Nota() { CiEstudiante = 4567, Idmateria = 11, NotaFinal = 80 };
            Nota nota4 = new Nota() { CiEstudiante = 9876, Idmateria = 11, NotaFinal = 54 };
            notas.Add(nota1);
            notas.Add(nota2);
            notas.Add(nota3);
            notas.Add(nota4);
        }

        private static void Materias_Seeder(List<Materia> materias)
        {
            Materia materia1 = new Materia() { Nombre = "Programacion C#", Idmateria = 21, Idcarrera = 20 };
            Materia materia2 = new Materia() { Nombre = "Java", Idmateria = 22, Idcarrera = 20 };
            Materia materia3 = new Materia() { Nombre = "Fisica Moderna", Idmateria = 11, Idcarrera = 10 };
            Materia materia4 = new Materia() { Nombre = "Calculo II", Idmateria = 12, Idcarrera = 10 };
            materias.Add(materia1);
            materias.Add(materia2);
            materias.Add(materia3);
            materias.Add(materia4);
        }

        private static void Estudiantes_Seeder(List<Estudiante> estudiantes)
        {
            Estudiante est1 = new Estudiante() { CiEstudiante = 7913188, Nombre = "Alejandro Obando", Telefono = 70725337, Direccion = "Av. Chapare" };
            Estudiante est2 = new Estudiante() { CiEstudiante = 1234, Nombre = "Andy Agramont", Telefono = 78303113, Direccion = "La Paz" };
            Estudiante est3 = new Estudiante() { CiEstudiante = 4567, Nombre = "Carlos Montaño", Telefono = 76549315, Direccion = "Lima Peru" };
            Estudiante est4 = new Estudiante() { CiEstudiante = 9876, Nombre = "Eddy Perez", Telefono = 64358974, Direccion = "Semapa" };
            estudiantes.Add(est1);
            estudiantes.Add(est2);
            estudiantes.Add(est3);
            estudiantes.Add(est4);
        }

        private static void Carreras_Seeder(List<Carrera> carreras)
        {
            Carrera carrera1 = new Carrera() { IdCarrera = 20, Nombre = "Ingenieria de Sistemas" };
            Carrera carrera2 = new Carrera() { IdCarrera = 10, Nombre = "Ingenieria Electronica" };
            carreras.Add(carrera1);
            carreras.Add(carrera2);
        }

        private static void Ingresar_Carrera(List<Carrera> carreras)
        {
            Carrera carrera = new Carrera();
            carrera.Ingresar_Carrera();
            carreras.Add(carrera);
        }

        private static void Buscar_Notas(List<Estudiante> estudiantes, List<Nota> notas, List<Materia> materias, List<Carrera> carreras)
        {
            Console.Clear();
            Console.WriteLine("Ingrese ID de Materia");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese CI de Estudiante:");
            int CI = int.Parse(Console.ReadLine());
            Nota res1 = Notas_Query(notas, ID, CI);
            Estudiante res2 = Est_Query(estudiantes, CI);
            Materia res3 = Mat_Query(materias, ID);
            Carrera res4 = Carrera_Query(carreras, res3);

            if (res1 != null && res2 != null && res3 != null && res4 != null)
            {
                Console.Clear();
                Console.WriteLine("Nota del Estudiante:");
                Console.WriteLine($"Nombre: {res2.Nombre}");
                Console.WriteLine($"CI: {res2.CiEstudiante}");
                Console.WriteLine($"Materia: {res3.Nombre}");
                Console.WriteLine($"Carrera: {res4.Nombre}");
                Console.WriteLine($"Nota: {res1.NotaFinal}");
                Console.WriteLine("Presione 'enter' para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No existen notas para el estudiante en esa materia");
                Console.WriteLine("Presione 'enter' para continuar...");
                Console.ReadKey();
            }
        }

        private static Carrera Carrera_Query(List<Carrera> carreras, Materia res3)
        {
            Carrera res4;
            if (res3 != null)
            {
                res4 = (from carrera in carreras
                        where carrera.IdCarrera == res3.Idcarrera
                        select carrera).FirstOrDefault();
            }
            else
            {
                res4 = null;
            }

            return res4;
        }

        private static Materia Mat_Query(List<Materia> materias, int ID)
        {
            return (from materia in materias
                    where materia.Idmateria == ID
                    select materia).FirstOrDefault();
        }

        private static Nota Notas_Query(List<Nota> notas, int ID, int CI)
        {
            return (from nota in notas
                    where nota.Idmateria == ID && nota.CiEstudiante == CI
                    select nota).FirstOrDefault();
        }

        private static void Buscar_Estudiante(List<Estudiante> estudiantes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese CI estudiante:");
            int CI = int.Parse(Console.ReadLine());
            Estudiante estudianteQuerty = Est_Query(estudiantes, CI);

            if (estudianteQuerty != null)
            {
                estudianteQuerty.Mostrar_Datos_Estudiante();
            }
            else
            {
                Console.WriteLine("Estudiante inexistente..");
                Console.WriteLine("Presione 'enter' para continuar...");
                Console.ReadKey();
            }
        }

        private static Estudiante Est_Query(List<Estudiante> estudiantes, int CI)
        {
            return (from est in estudiantes
                    where est.CiEstudiante == CI
                    select est).FirstOrDefault();
        }

        private static void Ingresar_Notas(List<Nota> notas)
        {
            Nota nota = new Nota();
            nota.Ingresar_Notas();
            notas.Add(nota);
        }

        private static void Crear_Materia(List<Materia> materias)
        {
            Materia mat = new Materia();
            mat.Rellenar_Materia();
            materias.Add(mat);
        }

        static void Menu_1(List<Estudiante> estudiantes, List<Nota> notas, List<Materia> materias, List<Carrera> carreras)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Por Favor Seleccione una opcion para continuar:");
            Console.WriteLine("1. Ingresar Informacion de Alumno");
            Console.WriteLine("2. Ingresar Informacion de Materia");
            Console.WriteLine("3. Ingresar Notas");
            Console.WriteLine("4. Crear nueva Carrera");
            Console.WriteLine("5. Buscar Estudiantes");
            Console.WriteLine("6. Buscar Notas");
            Console.WriteLine("7. Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    Crear_Estudiante(estudiantes);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "2":
                    Crear_Materia(materias);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "3":
                    Ingresar_Notas(notas);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "4":
                    Ingresar_Carrera(carreras);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "5":
                    Buscar_Estudiante(estudiantes);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "6":
                    Buscar_Notas(estudiantes, notas, materias, carreras);
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Seleccion invalida presione 'enter' para continuar...");
                    Console.ReadKey();
                    Menu_1(estudiantes, notas, materias, carreras);
                    break;
            }
        }

        static void Menu_2(List<Estudiante> estudiantes, List<Nota> notas, List<Materia> materias, List<Carrera> carreras)
        {
            Console.Clear();
            Console.WriteLine("¿Que desea hacer ahora?");
            Console.WriteLine("1. Volver a Menu");
            Console.WriteLine("2. Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    Menu_1(estudiantes, notas, materias, carreras);
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Seleccion invalida presione 'enter' para continuar...");
                    Console.ReadKey();
                    Menu_2(estudiantes, notas, materias, carreras);
                    break;
            }
        }
        static void Crear_Estudiante(List<Estudiante> estudiantes)
        {
            Estudiante est = new Estudiante();
            est.Rellenar_Estudiante();
            estudiantes.Add(est);
        }
    }
}
