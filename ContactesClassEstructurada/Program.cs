using System;

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Agregar Contacto   2. Ver Contactos   3. Buscar   4. Editar   5. Eliminar   6. Salir");
            Console.Write("Opción: ");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    agenda.AddContact();
                    break;
                case 2:
                    agenda.ViewContacts();
                    break;
                case 3:
                    agenda.SearchContact();
                    break;
                case 4:
                    agenda.EditContact();
                    break;
                case 5:
                    agenda.DeleteContact();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
