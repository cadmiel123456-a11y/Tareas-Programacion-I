public class Paciente
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Telefono { get; set; }

    public Paciente(string cedula, string nombre, int edad, string telefono)
    {
        Cedula = cedula;
        Nombre = nombre;
        Edad = edad;
        Telefono = telefono;
    }

    public override string ToString()
    {
        return $"Cédula: {Cedula}, Nombre: {Nombre}, Edad: {Edad}, Teléfono: {Telefono}";
    }
}
