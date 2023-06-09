using System;

namespace BeforeNightFall
{
    internal class Util
    {
        public void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(20);
            }
            Console.Write("\n");
        }

        public void CenterText(string text)
        {
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
            Console.Write("\n");
        }

        public void statsPlayer()
        {
            Console.WriteLine("     race = " + Program.playerStats.race);
            Console.WriteLine("     name = " + Program.playerStats.name);
            Console.WriteLine("     health = " + Program.playerStats.health);
            Console.WriteLine($"    level = {Program.playerStats.level}");
            Console.WriteLine($"    xp = {Program.playerStats.XP}/{Program.playerStats.XPcap}");
            Console.WriteLine("     Primary Weapon = " + Program.playerStats.weaponOne + ";   Dmg = " + Program.playerStats.weaponOneDamage + ";   speed = " + Program.playerStats.attackspeedOne);
            Console.WriteLine("     secondary Weapon = " + Program.playerStats.weaponTwo + ";   Dmg = " + Program.playerStats.weaponTwoDamage + ";   speed = " + Program.playerStats.attackspeedTwo);
            Console.WriteLine("     spacial attacks left; " + Program.playerStats.specialAttack);
            Console.WriteLine("     Armor = " + Program.playerStats.armor + ";   Protection = " + Program.playerStats.protection);
            Console.WriteLine("     survivid rooms = " + Program.myGame.room);
        }

        public void WRONGINPUT()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.util.CenterText("WRONG INPUT DETECTET");
            System.Threading.Thread.Sleep(1500);
            Console.ResetColor();
            Console.Clear();
        }

        public void Break()
        {
            Console.WriteLine("\n\n");
        }
    }
}