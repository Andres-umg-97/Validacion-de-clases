using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class MicroBus : Vehiculo
    {
        protected int CapacidadTanque { get; set; } = 75;
        protected int ConsumoGasolina { get; set; } = 1;
        protected int VelocidadMaxima { get; set; } = 80;
        public MicroBus(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> {"B" };
        }
    }
}
