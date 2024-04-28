using simulacroExamFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroExamFinal.Servicios
{
    internal class VehiculoImplementacion : VehiculoInterfaz
    {

        public List<Vehiculo> crearVehiculo(List<Vehiculo> listaVehiculo)
        {

            Vehiculo nuevoVehiculo = new Vehiculo();

            DateTime fecha4 = DateTime.Now;
            fecha4.ToString("yy - MM - ddThh:mm: ss");
            string fechaLlegadaString = fecha4.ToString();
            Console.WriteLine(fechaLlegadaString);
            

            nuevoVehiculo.IdVehiculo = crearId(listaVehiculo);
            nuevoVehiculo.FechaLlegadaAControl = fechaLlegadaString;
            Console.WriteLine("matricula");
            nuevoVehiculo.Matricula = Console.ReadLine(); 
            Console.WriteLine("Tipo vehiculo");
            nuevoVehiculo.TipoVehiculo = Console.ReadLine();
            Console.WriteLine("zona destino");
            nuevoVehiculo.ZonaDestino = Console.ReadLine();
            Console.WriteLine("carga vehiculo: si/no");
            string patata = "no";
            patata = Console.ReadLine();
            if(patata == "si") 
                { nuevoVehiculo.MercanciaSiNo=true; }
            else
                { nuevoVehiculo.MercanciaSiNo = false; }

            listaVehiculo.Add(nuevoVehiculo);
            return listaVehiculo;
            
        }

        private long crearId(List<Vehiculo> listaVehiculo)
        {
            int tamanyoLista = listaVehiculo.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = listaVehiculo[tamanyoLista - 1].IdVehiculo + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaId;
        }

    }
}
