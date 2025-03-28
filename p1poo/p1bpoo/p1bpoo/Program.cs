
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());


Chofer pilot1 = new Chofer("Monica", 21, "B");
Chofer pilot2 = new Chofer("Andrea", 31, "M");
Chofer pilot3 = new Chofer("Maria", 24, "A");

//pilot1.MostrarInformacion();
//pilot2.MostrarInformacion();
//pilot3.MostrarInformacion();

Vehiculo sedan = new Vehiculo(2025, "Azul", "Toyota");

Console.WriteLine(sedan.Encender());
sedan.acelerar(10);
Console.WriteLine(sedan.AsignarPiloto(pilot1));
Console.WriteLine(sedan.Encender());
sedan.acelerar(10);

//string respuesta = sedan.AsignarPiloto(pilot3);
//Console.WriteLine(respuesta);


Moto honda = new Moto(2025, "Rojo", "Honda");
Console.WriteLine(honda.AsignarPiloto(pilot2));

Trailer pitts = new Trailer(2025, "Blanco", "Pitts");
Console.WriteLine(pitts.Encender());
pitts.acelerar(10);
Console.WriteLine(pitts.AsignarPiloto(pilot3));

MicroBus Honda = new MicroBus(2025, "Blanco", "Honda");


