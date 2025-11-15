using System.Collections.Generic;
using System.Linq;

public class Agenda
{
    private List<Paciente> pacientes = new List<Paciente>();

    public void AgregarPaciente(Paciente p)
    {
        pacientes.Add(p);
    }

    public List<Paciente> ObtenerTodos()
    {
        return pacientes;
    }

    public Paciente BuscarPorCedula(string cedula)
    {
        return pacientes.FirstOrDefault(p => p.Cedula == cedula);
    }

    public bool EliminarPaciente(string cedula)
    {
        var paciente = BuscarPorCedula(cedula);
        if (paciente != null)
        {
            pacientes.Remove(paciente);
            return true;
        }
        return false;
    }
}
