using simulacroExamFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroExamFinal.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int primerMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Crear vehiculo");
            Console.WriteLine("2. Elejir zona");
            Console.WriteLine("-----------------");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

    }
}
