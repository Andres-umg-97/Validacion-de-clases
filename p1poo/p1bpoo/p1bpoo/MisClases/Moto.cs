using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
        }

        public int Velocidad { get; private set; }
        public int EstadoVehiculo { get; private set; }
        protected int CapacidadTanque { get; set; } = 40;
        protected int ConsumoGasolina { get; set; } = 1;
        protected int VelocidadMaxima { get; set; } = 90;

        public string HacerCaballito()
        {
            if (EstadoVehiculo != 2)
            {
                return "¡No se puede hacer caballito! La moto debe estar en movimiento.";
            }

            if (Velocidad < 20)
            {
                return "¡Deber ir mas rapido! (mínimo 20 km/h) para hacer el caballito.";
            }

            return "¡Felicidad! lograstes hacer un caballito" + Modelo;
        }
    }
}
