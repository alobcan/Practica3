using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Nota
    {
        public int Idmateria { get; set; }
        public int CiEstudiante { get; set; }
        public int NotaFinal { get; set; }

        public void Ingresar_Notas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese CI Estudiante:");
            this.CiEstudiante = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ID de Materia:");
            this.Idmateria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota:");
            this.NotaFinal = int.Parse(Console.ReadLine());
            Console.WriteLine("Presione 'enter' para continuar...");
            Console.ReadKey();
        }

        
    }
}