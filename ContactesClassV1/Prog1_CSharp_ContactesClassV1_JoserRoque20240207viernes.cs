Console.WriteLine("Bienvenido a mi lista de Contactos");

bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contacto     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = ReadInt();

    switch (typeOption)
    {
        case 1:
            AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 2:
            ShowContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 3:
            SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 4:
            ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 5:
            DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 6:
            runing = false;
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}

static int ReadInt()
{
    int value;
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Solo números. Intente de nuevo:");
    }
    return value;
}

static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
                       Dictionary<int, string> addresses, Dictionary<int, string> telephones,
                       Dictionary<int, string> emails, Dictionary<int, int> ages,
                       Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre");
    string name = Console.ReadLine();

    Console.WriteLine("Digite el apellido");
    string lastname = Console.ReadLine();

    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();

    Console.WriteLine("Digite el telefono");
    string phone = Console.ReadLine();

    Console.WriteLine("Digite el email");
    string email = Console.ReadLine();

    Console.WriteLine("Digite la edad");
    int age = ReadInt();

    Console.WriteLine("¿Es mejor amigo? 1=Si, 2=No");
    bool isBestFriend = ReadInt() == 1;

    int id = ids.Count + 1;

    ids.Add(id);
    names[id] = name;
    lastnames[id] = lastname;
    addresses[id] = address;
    telephones[id] = phone;
    emails[id] = email;
    ages[id] = age;
    bestFriends[id] = isBestFriend;

    Console.WriteLine("Contacto agregado correctamente.");
}

static void ShowContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
                         Dictionary<int, string> addresses, Dictionary<int, string> telephones,
                         Dictionary<int, string> emails, Dictionary<int, int> ages,
                         Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("ID   Nombre    Apellido    Dirección    Teléfono    Email    Edad    Mejor Amigo?");
    Console.WriteLine("------------------------------------------------------------------------------------------------");

    foreach (var id in ids)
    {
        string best = bestFriends[id] ? "Sí" : "No";
        Console.WriteLine($"{id}  {names[id]}   {lastnames[id]}   {addresses[id]}   {telephones[id]}   {emails[id]}   {ages[id]}   {best}");
    }
}

static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
                         Dictionary<int, string> addresses, Dictionary<int, string> telephones,
                         Dictionary<int, string> emails, Dictionary<int, int> ages,
                         Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto a buscar:");
    int id = ReadInt();

    if (!ids.Contains(id))
    {
        Console.WriteLine("El contacto no existe.");
        return;
    }

    Console.WriteLine("Contacto encontrado:");
    Console.WriteLine($"Nombre: {names[id]}");
    Console.WriteLine($"Apellido: {lastnames[id]}");
    Console.WriteLine($"Dirección: {addresses[id]}");
    Console.WriteLine($"Teléfono: {telephones[id]}");
    Console.WriteLine($"Email: {emails[id]}");
    Console.WriteLine($"Edad: {ages[id]}");
    Console.WriteLine($"Mejor amigo: {(bestFriends[id] ? "Sí" : "No")}");
}

static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
                         Dictionary<int, string> addresses, Dictionary<int, string> telephones,
                         Dictionary<int, string> emails, Dictionary<int, int> ages,
                         Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto a modificar:");
    int id = ReadInt();

    if (!ids.Contains(id))
    {
        Console.WriteLine("El contacto no existe.");
        return;
    }

    Console.WriteLine("Nuevo nombre (enter = dejar igual):");
    string name = Console.ReadLine();
    if (name != "") names[id] = name;

    Console.WriteLine("Nuevo apellido:");
    string last = Console.ReadLine();
    if (last != "") lastnames[id] = last;

    Console.WriteLine("Nueva dirección:");
    string adr = Console.ReadLine();
    if (adr != "") addresses[id] = adr;

    Console.WriteLine("Nuevo teléfono:");
    string tel = Console.ReadLine();
    if (tel != "") telephones[id] = tel;

    Console.WriteLine("Nuevo email:");
    string em = Console.ReadLine();
    if (em != "") emails[id] = em;

    Console.WriteLine("Nueva edad:");
    string ageStr = Console.ReadLine();
    if (ageStr != "") ages[id] = int.Parse(ageStr);

    Console.WriteLine("Mejor amigo? 1=Si, 2=No (enter = dejar igual)");
    string bf = Console.ReadLine();
    if (bf == "1") bestFriends[id] = true;
    if (bf == "2") bestFriends[id] = false;

    Console.WriteLine("Contacto modificado correctamente.");
}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
                         Dictionary<int, string> addresses, Dictionary<int, string> telephones,
                         Dictionary<int, string> emails, Dictionary<int, int> ages,
                         Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto a eliminar:");
    int id = ReadInt();

    if (!ids.Contains(id))
    {
        Console.WriteLine("El contacto no existe.");
        return;
    }

    ids.Remove(id);
    names.Remove(id);
    lastnames.Remove(id);
    addresses.Remove(id);
    telephones.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    bestFriends.Remove(id);

    Console.WriteLine("Contacto eliminado correctamente.");
}
