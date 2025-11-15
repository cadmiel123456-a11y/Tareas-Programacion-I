using System;
using System.Collections.Generic;

public class Agenda
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact()
    {
        Console.Write("Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Teléfono: ");
        string phone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Dirección: ");
        string address = Console.ReadLine();

        int id = contacts.Count + 1;

        contacts.Add(new Contact(id, name, phone, email, address));

        Console.WriteLine("Contacto agregado.");
    }

    public void ViewContacts()
    {
        Console.WriteLine("ID   Nombre   Teléfono   Email   Dirección");
        Console.WriteLine("------------------------------------------");

        foreach (var c in contacts)
        {
            Console.WriteLine($"{c.Id}   {c.Name}   {c.Phone}   {c.Email}   {c.Address}");
        }
    }

    public void SearchContact()
    {
        Console.Write("ID a buscar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Contact c = contacts.Find(x => x.Id == id);

        if (c == null)
        {
            Console.WriteLine("No encontrado.");
            return;
        }

        Console.WriteLine($"Nombre: {c.Name}");
        Console.WriteLine($"Teléfono: {c.Phone}");
        Console.WriteLine($"Email: {c.Email}");
        Console.WriteLine($"Dirección: {c.Address}");
    }

    public void EditContact()
    {
        Console.Write("ID a editar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Contact c = contacts.Find(x => x.Id == id);

        if (c == null)
        {
            Console.WriteLine("No existe.");
            return;
        }

        Console.Write("Nuevo nombre: ");
        c.Name = Console.ReadLine();

        Console.Write("Nuevo teléfono: ");
        c.Phone = Console.ReadLine();

        Console.Write("Nuevo email: ");
        c.Email = Console.ReadLine();

        Console.Write("Nueva dirección: ");
        c.Address = Console.ReadLine();

        Console.WriteLine("Actualizado.");
    }

    public void DeleteContact()
    {
        Console.Write("ID a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Contact c = contacts.Find(x => x.Id == id);

        if (c == null)
        {
            Console.WriteLine("No existe.");
            return;
        }

        contacts.Remove(c);

        Console.WriteLine("Eliminado.");
    }
}
