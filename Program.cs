using System;
using static System.Console;
using keyboardMenuDemo;
using ManagerGame;
namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "play", "display", "exit" };
            string prompt = @"
░█████╗░████████╗  ░██████╗████████╗░█████╗░██████╗░███████╗
██╔══██╗╚══██╔══╝  ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝░░░██║░░░  ╚█████╗░░░░██║░░░██║░░██║██████╔╝█████╗░░
██║░░██╗░░░██║░░░  ░╚═══██╗░░░██║░░░██║░░██║██╔══██╗██╔══╝░░
╚█████╔╝░░░██║░░░  ██████╔╝░░░██║░░░╚█████╔╝██║░░██║███████╗
░╚════╝░░░░╚═╝░░░  ╚═════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚══════╝";
            Menu menu = new Menu(prompt, options);
            Game game = new Game();
            int SelectedIndex;
            // ConsoleKey keyPressed;
            // ConsoleKeyInfo keyInfo = ReadKey(true);
            // keyPressed = keyInfo.Key;
            do
            {
                SelectedIndex = menu.Run();
                
                switch (SelectedIndex)
                {
                    case 0:
                        game.play();
                        break;
                    case 1:
                        game.display();
                        break;
                    case 2:
                        game.exit();
                        break;


                }
            } while (SelectedIndex != 2);

        }
    }
}