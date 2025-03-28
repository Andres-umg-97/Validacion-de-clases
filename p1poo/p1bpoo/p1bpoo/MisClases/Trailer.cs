using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Trailer : Vehiculo
    {
        protected int CapacidadTanque { get; set; } = 100;
        protected int ConsumoGasolina { get; set; } = 10;
        protected int VelocidadMaxima { get; set; } = 100;

        public Trailer(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
        }
        
   
       
    }
}
