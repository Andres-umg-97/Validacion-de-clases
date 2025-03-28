using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;
        protected int CapacidadTanque { get; set; } = 50;
        protected int ConsumoComustible { get; set; } = 1;
        protected int VelocidadMaxima { get; set; } = 120;

        //tipo de licencia 
        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C", "M" };

        private Chofer piloto = null;
        private int estadoVehiculo = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento;

        //agregar el metodo de asignar piloto:
        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado";
            }
            if (piloto != null)
            {
                return "El vehiculo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";
        }

        public string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehiculo sin un piloto asignado";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Vehiculo encendido";
            }
            return "El vehiculo ya esta encendido";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.VelocidadMaxima = 120;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("*** Informacion del Vehiculo ***");
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("Velocidad actual: {0}", this.velocidad);
            Console.WriteLine("Velicad Maxima: {0}", this.VelocidadMaxima);

            string estado = "";
            switch (this.estadoVehiculo)
            {
                case 0: estado = "Apagado"; break;
                case 1: estado = "Encendido"; break;
                case 2: estado = "En movimiento"; break;
            }
            Console.WriteLine("Estado del vehiculo: {0}", estado);
            if (this.piloto == null)
            {
                Console.WriteLine("No hay piloto asignado");
            }
            else
            {
                Console.WriteLine("Piloto asignado:");
                Console.WriteLine("- Nombre: {0}", this.piloto.Nombre);
                Console.WriteLine("- Edad: {0} años", this.piloto.Edad);
                Console.WriteLine("- Tipo de licencia: {0}", this.piloto.TipoLicencia);
            }
        }
        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("no se puede acelerar si el carro esta apagado");
                return;
            }
            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine("Precaucion,no se puede superar la velocidad maxima establecida", VelocidadMaxima);
                return;
            }
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }

        public void frenar(int cuanto)
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("no se puede frenar cuando el vehiculo este apagado");
                return;
            }
            velocidad -= cuanto;
            if (velocidad < 0)
            {
                velocidad = 0;
                estadoVehiculo = 1;
                Console.WriteLine("El vehiculo esta detenido: listo para poder moverse");
            }
            else
            {
                Console.WriteLine("la velocidad actual es:", velocidad);
            }
        }

        public string Apagar()
        {
            if (estadoVehiculo == 0)
            {
                return "El vehiculo no se puede apagar si esta en movimiento, debes frenar primero";
            }
            if (estadoVehiculo == 0)
            {
                return "El vehiculo ya esta apagado";
            }
            estadoVehiculo = 0;
            return "El vehiculo esta apagado";

        }
    }
}
