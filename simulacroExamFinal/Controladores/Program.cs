using simulacroExamFinal.Dtos;
using simulacroExamFinal.Servicios;

namespace simulacroExamFinal.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            List<Vehiculo> listavehiculo = new List<Vehiculo>();
            VehiculoInterfaz vi = new VehiculoImplementacion();

            vi.crearVehiculo(listavehiculo);
            

        }

    }

}