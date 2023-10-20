using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4rpm
{
    class AEROFLOT : ICloneable, IComparable<AEROFLOT>
    {
        public string Destination { get; set; }
        public int FlightNumber { get; set; }
        public string AircraftType { get; set; }

        // Конструктор класса AEROFLOT
        public AEROFLOT(string destination, int flightNumber, string aircraftType)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            AircraftType = aircraftType;
        }

        // Реализация интерфейса ICloneable для клонирования объекта
        public object Clone()
        {
            return new AEROFLOT(Destination, FlightNumber, AircraftType);
        }

        // Реализация интерфейса IComparable для сортировки по номеру рейса
        public int CompareTo(AEROFLOT other)
        {
            return FlightNumber.CompareTo(other.FlightNumber);
        }
    }
}
