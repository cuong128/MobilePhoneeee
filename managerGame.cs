using System;
namespace ManagerGame
{
    class Game
    {
        public void display()
        {
            Console.WriteLine("1");
            Console.ReadKey();
        }
        public void play()
        {
            Console.WriteLine("2");
            Console.ReadKey();
        }
        public void exit()
        {
            Console.WriteLine("Press key to any exit ... ");
            Console.ReadLine();
        }
    }
    
}