using lab4rpm;

class Program
{
    static void Main(string[] args)
    {
        AEROFLOT[] flights = new AEROFLOT[7];

        // Ввод данных с клавиатуры
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Введите данные для рейса {i + 1}:");
            Console.Write("Название пункта назначения: ");
            string destination = Console.ReadLine();
            Console.Write("Номер рейса: ");
            int flightNumber = int.Parse(Console.ReadLine());
            Console.Write("Тип самолета: ");
            string aircraftType = Console.ReadLine();

            flights[i] = new AEROFLOT(destination, flightNumber, aircraftType);
        }

        // Сортировка массива по номеру рейса
        Array.Sort(flights);

        // Вывод данных на экран
        Console.WriteLine("Введите пункт назначения для поиска:");
        string searchDestination = Console.ReadLine();

        bool found = false;
        foreach (var flight in flights)
        {
            if (flight.Destination == searchDestination)
            {
                Console.WriteLine($"Номер рейса: {flight.FlightNumber}, Тип самолета: {flight.AircraftType}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Рейсов в указанный пункт назначения не найдено.");
        }

        // Сортировка массива по типу самолета с использованием IComparer
        Array.Sort(flights, new AircraftTypeComparer());
    }
}