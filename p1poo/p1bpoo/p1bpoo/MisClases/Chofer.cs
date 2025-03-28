public class Chofer : IPiloto
{
    private string _tipoLicencia;  // Campo privado para encapsulación

    public string Nombre { get; set; }
    public int Edad { get; set; }

    public string TipoLicencia
    {
        get => _tipoLicencia;
        set
        {
            ValidarLicencia(Edad, value);  // Validación al asignar
            _tipoLicencia = value;
        }
    }

    public Chofer(string nombre, int edadPiloto, string tipoLicencia)
    {
        Nombre = nombre;
        Edad = edadPiloto;
        TipoLicencia = tipoLicencia; // Usa el setter con validación
    }

    private void ValidarLicencia(int edad, string tipoLicencia)
    {
        if (string.IsNullOrEmpty(tipoLicencia))
            throw new ArgumentException("El tipo de licencia no puede estar vacío");

        switch (tipoLicencia.ToUpper())
        {
            case "A":
            case "B":
                if (edad < 23)
                    throw new Exception($"La edad mínima para licencia tipo {tipoLicencia} es 23 años");
                break;
            case "C":
            case "M":
                if (edad < 16)
                    throw new Exception($"La edad mínima para licencia tipo {tipoLicencia} es 16 años");
                break;
            default:
                throw new ArgumentException($"Tipo de licencia no válido: {tipoLicencia}");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Tipo de Licencia: {TipoLicencia}");
    }
}