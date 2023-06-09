using System;
using System.Runtime.InteropServices;

namespace BeforeNightFall
{
    internal class Program
    {
        public static Game myGame = new Game();
        public static Util util = new Util();
        public static about about = new about();
        public static roomGen roomgen = new roomGen();
        public static playerstats playerStats = new playerstats();

        //gets info to set window full screen
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        //
        private static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            myGame.intro = true;
            roomgen.Generate();
            myGame.start();
        }
    }
}