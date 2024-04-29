using simulacroExamFinal.Dtos;
using simulacroExamFinal.Servicios;
using System.Numerics;

namespace simulacroExamFinal.Controladores
{

    class Program
    {
        static public string rutaFile = "C:\\Users\\Yo MSI\\Desktop\\vehiculos2.txt";
        static public string rutaFileLog = "C:\\Users\\Yo MSI\\Desktop\\log.txt";
        static void Main(string[] args)
        {

            List<Vehiculo> listavehiculo = new List<Vehiculo>();
            VehiculoInterfaz vi = new VehiculoImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            int opcionSeleccionada;
            bool cerrarMenu = false;

            do
            {
                opcionSeleccionada = mi.primerMenu();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        vi.crearVehiculo(listavehiculo);
                        break;
                    case 2:
                        //elegir zona
                        vi.meterEnFichero(listavehiculo);
                        break;
                    default:
                        break;
                }

            } while (!cerrarMenu);

            /*
            string ruta = "patata";
            StreamReader sr = new StreamReader(ruta);
            string[] linea = File.ReadAllLines(ruta);
            */
            

        }

    }

}