using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroExamFinal.Dtos
{
    internal class Vehiculo
    {

        //atributos
        private long idVehiculo;
        private string matricula = "aaa";
        private string tipoVehiculo = "aaa";
        private string zonaDestino = "aaa";
        private bool mercanciaSiNo = false;
        private string fechaLlegadaAControl = "31/12/9999 00:00:00";

       
        //getter and setter
        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public bool MercanciaSiNo { get => mercanciaSiNo; set => mercanciaSiNo = value; }
        public string FechaLlegadaAControl { get => fechaLlegadaAControl; set => fechaLlegadaAControl = value; }


        //Constructores
        public Vehiculo(long idVehiculo, string matricula, string tipoVehiculo, string zonaDestino, bool mercanciaSiNo, string fechaLlegadaAControl)
        {
            this.IdVehiculo = idVehiculo;
            this.Matricula = matricula;
            this.TipoVehiculo = tipoVehiculo;
            this.ZonaDestino = zonaDestino;
            this.MercanciaSiNo = mercanciaSiNo;
            this.FechaLlegadaAControl = fechaLlegadaAControl;
        }

        public Vehiculo() { }

        override
        public string ToString()
        { 
            string stringFichero = this.IdVehiculo + ";" + this.Matricula + ";" + this.TipoVehiculo + ";" + this.ZonaDestino + ";" + this.MercanciaSiNo + ";" + this.FechaLlegadaAControl;
        
            return stringFichero;
        }
    }
}
