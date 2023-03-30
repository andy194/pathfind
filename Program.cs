using Pathfinder;
namespace PathfinderApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Finder finder = new Finder();

            finder.setMap(new List<string>
            {
                ". . . . .",
                ". # # # .",
                ". . . . .",
                ". . . . .",
                ". . . . ."
            });

            int distance = finder.findRoute(new Cell(0,1), new Cell(3,2));

            Console.WriteLine("Distance to goal: " + distance);
        }
    }
}