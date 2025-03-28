interface IPiloto
{
    string Nombre { get; set; }
    int Edad { get; set; }
    string TipoLicencia { get; set; }

    void MostrarInformacion();
}
