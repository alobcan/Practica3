using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }

        public void Ingresar_Carrera()
        {
            Console.Clear();
            Console.WriteLine("Ingrese Nombre Carrera:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese ID de Carrera:");
            this.IdCarrera = int.Parse(Console.ReadLine());
            Console.WriteLine("Presione 'enter' para continuar...");
            Console.ReadKey();
        }

        
    }
}