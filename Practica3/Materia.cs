using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Materia
    {
        public int Idmateria { get; set; }
        public string Nombre { get; set; }
        public int Idcarrera { get; set; }

        public void Rellenar_Materia()
        {
            Console.Clear();
            Console.WriteLine("Nombre:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("ID Materia:");
            this.Idmateria = int.Parse(Console.ReadLine());
            Console.WriteLine("ID Carrera:");
            this.Idcarrera = int.Parse(Console.ReadLine());
            Console.WriteLine("Presione 'enter' para continuar...");
            Console.ReadKey();
        }

       
    }
}