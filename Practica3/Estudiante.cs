using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Estudiante
    {
        public int CiEstudiante { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }

        public void Rellenar_Estudiante()
        {
            Console.Clear();
            Console.WriteLine("Nombre:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Carnet de Identidad:");
            this.CiEstudiante = int.Parse(Console.ReadLine());
            Console.WriteLine("Teléfono:");
            this.Telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("Dirección:");
            this.Direccion = Console.ReadLine();
            Console.WriteLine("Presione 'enter' Para continuar...");
            Console.ReadKey();
        }
        public void Mostrar_Datos_Estudiante()
        {
            Console.Clear();
            Console.WriteLine("Datos Estudiante:");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"CI: {this.CiEstudiante}");
            Console.WriteLine($"Teléfono: {this.Telefono}");
            Console.WriteLine($"Dirección: {this.Direccion}");
            Console.WriteLine("Presione 'enter' para continuar...");
            Console.ReadKey();
        }

    }
}