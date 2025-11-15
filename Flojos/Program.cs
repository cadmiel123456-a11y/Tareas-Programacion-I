using System;

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE REGISTRO DE PACIENTES ===");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Listar pacientes");
            Console.WriteLine("3. Buscar paciente por cédula");
            Console.WriteLine("4. Eliminar paciente");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Cédula: ");
                    string cedula = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();

                    agenda.AgregarPaciente(new Paciente(cedula, nombre, edad, telefono));
                    Console.WriteLine("Paciente registrado con éxito.");
                    break;

                case 2:
                    Console.WriteLine("=== LISTA DE PACIENTES ===");
                    foreach (var p in agenda.ObtenerTodos())
                        Console.WriteLine(p);
                    break;

                case 3:
                    Console.Write("Ingrese la cédula: ");
                    string cedBus = Console.ReadLine();

                    var encontrado = agenda.BuscarPorCedula(cedBus);
                    if (encontrado != null)
                        Console.WriteLine("Paciente encontrado:\n" + encontrado);
                    else
                        Console.WriteLine("No existe un paciente con esa cédula.");
                    break;

                case 4:
                    Console.Write("Cédula a eliminar: ");
                    string cedDel = Console.ReadLine();

                    if (agenda.EliminarPaciente(cedDel))
                        Console.WriteLine("Paciente eliminado.");
                    else
                        Console.WriteLine("No se encontró el paciente.");
                    break;

                case 5:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }
}
