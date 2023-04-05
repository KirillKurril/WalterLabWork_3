//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Collections.Specialized.BitVector32;

namespace LabWork4
{
    public sealed class StationContainer
    {
        private static StationContainer __instance;
        private List<Station> _stations;

        private StationContainer()
        {
            _stations = new List<Station>();
        }

        public static StationContainer GetInstance()
        {
            return __instance ?? (__instance = new StationContainer());
        }

        public void AddStation(Station station)
        {
            _stations.Add(station);
        }

        public void RemoveStation(Station station)
        {
            _stations.Remove(station);
        }

        public List<Station> GetAllStations()
        {
            return _stations;
        }
    }

    public class Station
    {
        public string Name { get; set; }
        public decimal TicketPrice { get; private set; }
        public int TotalSeats { get; private set; }
        public int SoldSeats { get; private set; }

        public Station(string name, decimal ticketPrice, int totalSeats, int soldSeats)
        {
            Name = name;
            TicketPrice = ticketPrice;
            TotalSeats = totalSeats;
            SoldSeats = soldSeats;
        }

        public decimal CalculateTotalUnsoldTicketsPrice()
        {
            return TicketPrice * (TotalSeats - SoldSeats);
        }

        public void IncreaseTicketPrice(decimal amount)
        {
            TicketPrice += amount;
        }

        public void DecreaseTicketPrice(decimal amount)
        {
            if (TicketPrice - amount < 0)
            {
                throw new Exception("Ticket price cannot be negative.");
            }

            TicketPrice -= amount;
        }
    }

}
