/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace DMSolution
{
    public sealed class StationContainer
    {
        private static StationContainer? instance = null;    //singleton ? делает nullable
        private List<Station> stations;
        private StationContainer()
        {
            stations = new List<Station>();    
        }
        public static StationContainer GetInstance()
        {
            return instance ??= new StationContainer();
        }

        public void AddStation(Station station)
        {
            stations.Add(station);
        }

        public void RemoveStation(Station station)
        {
            stations.Remove(station);
        }

    }

    public class Station
    {
       
        public Station(string Name, double TicketPrice, UInt64 SeatsAmount, UInt64 SoldSeats) =>
            (name, ticketPrice, seatsAmount, soldSeats) = (Name, TicketPrice, SeatsAmount, SoldSeats); //упрощенная конструкция с плюсов через кортеж
        
        public string name { get; private set; }     //свойства
        public double ticketPrice { get; set; }
        public UInt64 seatsAmount { get; private set; }
        public UInt64 soldSeats { get; private set; }

        public double CalculateFreeSeatsCost()
        {
            return (seatsAmount - soldSeats) * ticketPrice;
        }
        public void IncreaseTicketPrice(double amount)
        {
            ticketPrice += amount;
        }

        public void DecreaseTicketPrice(double amount)
        {
            if (ticketPrice - amount < 0)
            {
                throw new Exception("Ticket price cannot be negative.");
            }

            ticketPrice -= amount;
        }
    }
}
