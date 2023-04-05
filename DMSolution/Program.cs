namespace DMSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var station1 = new Station("Station 1", 10.5, 50, 10);
            var station2 = new Station("Station 2", 10.5, 100, 25);

            var container = StationContainer.GetInstance();
            container.AddStation(station1);
            container.AddStation(station2);

            Console.WriteLine("Unsold tickets price for Station 1: " + station1.CalculateFreeSeatsCost()); // 420
            Console.WriteLine("Unsold tickets price for Station 2: " + station2.CalculateFreeSeatsCost()); // 787.5

            station1.IncreaseTicketPrice(1.5);
            Console.WriteLine("New ticket price for Station 1: " + station1.ticketPrice); // 12

            station2.DecreaseTicketPrice(2);
            Console.WriteLine("New ticket price for Station 2: " + station2.ticketPrice); // 8.5 

            Console.WriteLine("Unsold tickets price for Station 1: " + station1.CalculateFreeSeatsCost()); // 480
            Console.WriteLine("Unsold tickets price for Station 2: " + station2.CalculateFreeSeatsCost()); // 637.5

        }
    }
}