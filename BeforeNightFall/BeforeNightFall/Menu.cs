using System;

namespace BeforeNightFall
{
    internal class Menu
    {
        private int selectedIndex;
        private string[] options;
        private string prompt;
        private string prompt2;
        private string text;
        private string text2;
        private string text3;
        private string text4;

        public Menu(string prompt, string[] options)
        {
            text = "";
            text2 = "";
            text3 = "";
            text4 = "";
            this.prompt = prompt;
            prompt2 = "";
            this.options = options;
            selectedIndex = 0;
        }

        public Menu(string text, string prompt, string[] options)
        {
            this.text = text;
            text2 = "";
            text3 = "";
            text4 = "";
            this.prompt = prompt;
            prompt2 = "";
            this.options = options;
            selectedIndex = 0;
        }

        public Menu(string text, string prompt, string prompt2, string[] options)
        {
            this.text = text;
            text2 = "";
            text3 = "";
            text4 = "";
            this.prompt = prompt;
            this.prompt2 = prompt2;
            this.options = options;
            selectedIndex = 0;
        }

        public Menu(string text, string text2, string prompt, string prompt2, string[] options)
        {
            this.text = text;
            this.text2 = text2;
            text3 = "";
            text4 = "";
            this.prompt = prompt;
            this.prompt2 = prompt2;
            this.options = options;
            selectedIndex = 0;
        }

        public Menu(string text, string text2, string text3, string prompt, string prompt2, string[] options)
        {
            this.text = text;
            this.text2 = text2;
            this.text3 = text3;
            text4 = "";
            this.prompt = prompt;
            this.prompt2 = prompt2;
            this.options = options;
            selectedIndex = 0;
        }

        public Menu(string text, string text2, string text3, string text4, string prompt, string prompt2, string[] options)
        {
            this.text = text;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.prompt = prompt;
            this.prompt2 = prompt2;
            this.options = options;
            selectedIndex = 0;
        }

        public void DisplayOptions()
        {
            if (Program.myGame.intro)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Program.util.CenterText(text);
                Console.WriteLine();
                Program.util.CenterText(text2);
                Console.WriteLine();
                Program.util.CenterText(text3);
                Program.util.Break();
                Program.util.CenterText(text4);
                Program.util.Break();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.util.CenterText(prompt);
                Program.util.CenterText(prompt2);
                Console.ResetColor();
                for (int i = 0; i < options.Length; i++)
                {
                    string currentOption = options[i];
                    string prefix;

                    if (i == selectedIndex)
                    {
                        prefix = "> ";
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                        prefix = "  ";
                    }
                    Program.util.CenterText($"{prefix}{currentOption}");
                }
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Program.util.statsPlayer();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Program.util.CenterText(text);
                Console.WriteLine();
                Program.util.CenterText(text2);
                Console.WriteLine();
                Program.util.CenterText(text3);
                Program.util.Break();
                Console.ResetColor();
                Program.util.CenterText(text4);
                Program.util.Break();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.util.CenterText(prompt);
                Program.util.CenterText(prompt2);
                Console.ResetColor();
                for (int i = 0; i < options.Length; i++)
                {
                    string currentOption = options[i];
                    string prefix;
                    if (i == selectedIndex)
                    {
                        prefix = "> ";
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                        prefix = "  ";
                    }
                    Program.util.CenterText($"{prefix}{currentOption}");
                }
                Console.ResetColor();
            }
        }

        public void DisplaySelected()
        {
            if (Program.myGame.intro)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Program.util.CenterText(text);
                Console.WriteLine();
                Program.util.CenterText(text2);
                Console.WriteLine();
                Program.util.CenterText(text3);
                Program.util.Break();
                Program.util.CenterText(text4);
                Program.util.Break();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.util.CenterText(prompt);
                Program.util.CenterText(prompt2);
                Console.ResetColor();
                for (int i = 0; i < options.Length; i++)
                {
                    string currentOption = options[i];
                    string prefix;
                    if (i == selectedIndex)
                    {
                        prefix = " >";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        prefix = "  ";
                        Console.ResetColor();
                    }
                    Program.util.CenterText($"{prefix}{currentOption}");
                }
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Program.util.statsPlayer();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Program.util.CenterText(text);
                Console.WriteLine();
                Program.util.CenterText(text2);
                Console.WriteLine();
                Program.util.CenterText(text3);
                Program.util.Break();
                Program.util.CenterText(text4);
                Program.util.Break();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.util.CenterText(prompt);
                Program.util.CenterText(prompt2);
                Console.ResetColor();
                for (int i = 0; i < options.Length; i++)
                {
                    string currentOption = options[i];
                    string prefix;
                    if (i == selectedIndex)
                    {
                        prefix = " >";

                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        prefix = "  ";
                        Console.ResetColor();
                    }
                    Program.util.CenterText($"{prefix}{currentOption}");
                }
                Console.ResetColor();
            }
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                keyPressed = KeyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                }
                if (selectedIndex > options.Length - 1)
                {
                    selectedIndex = 0;
                }
                if (selectedIndex < 0)
                {
                    selectedIndex = options.Length - 1;
                }
            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }
    }
}