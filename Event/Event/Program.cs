using Event.Event;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();

            Player player1 = new Player()
            {
                Name = "messi",
                Team = "barca"
                   };
            Player player2 = new Player()
            {
                Name = "crs",
                Team = "madrid"
            };

            Refree refree = new Refree() { Name="ahmed"};

            Console.WriteLine("befor subscribe");

            //subscribe
            ball.OnLocationChanged += player1.Run;
            ball.OnLocationChanged += player2.Run;
            ball.OnLocationChanged += refree.Lock;

            Console.WriteLine("after subscribe");
            ball.Location=new Location() { X=1, Y=2,Z=3};
        }
    }
}