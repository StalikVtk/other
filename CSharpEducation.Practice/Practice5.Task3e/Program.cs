using Practice5.Task3d;
namespace Practice5.Task3e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] birds = new IFlyable[4];
            birds[0] = new Parrot("Kesha", 3, "red");
            birds[1] = new Eagle();
            birds[2] = new Eagle();
            birds[3] = new Parrot("Gosha", 5, "blue");

            foreach (var bird in birds)
            {
                bird.Fly();
            }
        }
    }
}
