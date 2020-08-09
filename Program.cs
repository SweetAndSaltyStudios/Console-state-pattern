using ConsoleStatePattern.States;

namespace ConsoleStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new HomeState());
            player.ConsoleInput();
            player.Move();
        }
    }
}