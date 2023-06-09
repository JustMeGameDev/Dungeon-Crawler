using System;

namespace BeforeNightFall
{
    internal class about
    {
        public void oke()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Program.util.CenterText("This game is made by JustMeGameDev");
            Program.util.CenterText("Inspierd by the Tower Defance Game Before Night-Fall.");
            Program.util.CenterText("visit https://justmegamedev.github.io/ For more info about me.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n");
            Program.util.CenterText("Press 'R' to return to menu");
            Console.ResetColor();
            ConsoleKey keyPressed;
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            keyPressed = KeyInfo.Key;
            if (keyPressed == ConsoleKey.R)
            {
                Program.myGame.start();
            }
            else
            {
                Program.util.WRONGINPUT();
                oke();
            }
        }
    }
}