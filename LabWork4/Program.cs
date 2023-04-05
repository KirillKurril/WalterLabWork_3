namespace LabWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var station1 = new Station("Station 1", 10.5m, 50, 10);
            var station2 = new Station("Station 2", 10.5m, 100, 25);

            var container = StationContainer.GetInstance();
            container.AddStation(station1);
            container.AddStation(station2);

            Console.WriteLine("Unsold tickets price for Station 1: " + station1.CalculateTotalUnsoldTicketsPrice()); // 420
            Console.WriteLine("Unsold tickets price for Station 2: " + station2.CalculateTotalUnsoldTicketsPrice()); // 787.5

            station1.IncreaseTicketPrice(1.5m);
            Console.WriteLine("New ticket price for Station 1: " + station1.TicketPrice); // 12

            station2.DecreaseTicketPrice(2m);
            Console.WriteLine("New ticket price for Station 2: " + station2.TicketPrice); // 8.5

        }
    }
}