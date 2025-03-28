using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        protected int CapacidadBateria { get; set; } = 100;
        protected int ConsumoBateria { get; set; } = 1;
        protected int VelocidadMaxima { get; set; } = 110;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }


    }
}
