using System;
using System.Collections.Generic;

namespace BeforeNightFall
{
    internal class Game
    {
        private Random rnd = new Random();

        public int room;
        public float tempf;
        private bool rest = false;
        public bool intro = true;
        private List<string> tempOptions = new List<string>();
        private List<string> tempOptions2 = new List<string>();
        public string tempText;
        public string tempText2;
        public string tempText3;
        public string tempText4;
        public string enemy1;
        public string enemy2;
        public string enemy3;
        private int j;

        private int currentRoom;

        public void start()
        {
            intro = true;
            string prompt = "Welcom to \"Before Night-Fall\" the text-RPG\n\n";
            string[] options = { "Play\n", "About\n", "Exit\n", };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    menu.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Entrance();
                    break;

                case 1:
                    menu.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.about.oke();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        public void Entrance()
        {
            Console.Clear();
            intro = true;
            string text = "You awake!, you look in the mrirror. What race do you see?\n\n";
            Console.ForegroundColor = ConsoleColor.Yellow;
            string prompt = "Select a Race please.\n";
            Console.ResetColor();
            string[] options = { "Demon\n", "Halfling\n", "Oger\n", "High Elf\n", "DragonBorn\n", "Human\n" };
            Menu RaceSelect = new Menu(text, prompt, options);
            int selectedIndex = RaceSelect.Run();

            switch (selectedIndex)
            {
                case 0:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "Demon";
                    Program.playerStats.heavy = true;
                    Entrance2();
                    break;

                case 1:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "Halfling";
                    Program.playerStats.sneak = true;
                    Entrance2();
                    break;

                case 2:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "Oger";
                    Program.playerStats.heavy = true;
                    Entrance2();
                    break;

                case 3:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "High Elf";
                    Program.playerStats.sneak = true;
                    Entrance2();
                    break;

                case 4:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "Dragon Born";
                    Program.playerStats.heavy = true;
                    Entrance2();
                    break;

                case 5:
                    RaceSelect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.race = "Human";
                    Program.playerStats.sneak = true;
                    Entrance2();
                    break;
            }
        }

        public void Entrance2()
        {
            Console.Clear();
            intro = true;

            Console.WriteLine("\n\n\n\n");
            Program.util.CenterText($"what is your name {Program.playerStats.race}");
            Program.playerStats.name = Console.ReadLine();
            Program.util.CenterText($"If your brave enough {Program.playerStats.name}. press 'Enter' to continiu.");
            ConsoleKey keyPressed;
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            keyPressed = KeyInfo.Key;
            if (keyPressed == ConsoleKey.Enter)
            {
                WeaponsRoom();
            }
            else
            {
                Program.util.WRONGINPUT();
                Entrance2();
            }
        }

        public void WeaponsRoom()
        {
            Console.Clear();
            intro = true;
            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string text = "You ventur forth into a dungeon.The first room you see is a weaponsroom.You think to yourself i need a weapon. which one do i choose as primary weapon?\n\n";
            string prompt = "Select a Primary Weapon please.\n\n";
            Console.ResetColor();
            string[] options = { "Rusty Old Sword\n", "Bend Longbow\n", "Dull Dual-Wielded daggers\n", "Deformed Battle Axe\n", "Broken Pike\n" };
            Menu weapononeselect = new Menu(text, prompt, options);
            int selectedIndex = weapononeselect.Run();
            switch (selectedIndex)
            {
                case 0:
                    weapononeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponOne = "Rusty Old Sword";
                    Program.playerStats.weaponOneDamage = rnd.Next(8, 19);
                    Program.playerStats.attackspeedOne = rnd.Next(1, 3);
                    weaponsroom2();
                    break;

                case 1:
                    weapononeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponOne = "Bend Longbow";
                    Program.playerStats.weaponOneDamage = rnd.Next(9, 25);
                    Program.playerStats.attackspeedOne = rnd.Next(0, 6);
                    weaponsroom2();
                    break;

                case 2:
                    weapononeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponOne = "Dull Dual-Wielded daggers";
                    Program.playerStats.weaponOneDamage = rnd.Next(3, 16);
                    Program.playerStats.attackspeedOne = rnd.Next(2, 6);
                    weaponsroom2();
                    break;

                case 3:
                    weapononeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponOne = "Deformed Battle Axe";
                    Program.playerStats.weaponOneDamage = rnd.Next(15, 26);
                    Program.playerStats.attackspeedOne = rnd.Next(0, 2);
                    weaponsroom2();
                    break;

                case 4:
                    weapononeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponOne = "Broken Pike";
                    Program.playerStats.weaponOneDamage = rnd.Next(11, 16);
                    Program.playerStats.attackspeedOne = rnd.Next(2, 4);
                    weaponsroom2();
                    break;
            }
        }

        public void weaponsroom2()
        {
            intro = false;
            Console.Clear();
            Program.util.statsPlayer();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string prompt = "Select a Secundary Weapon please.\n\n";
            Console.ResetColor();
            string[] options = { "Slingshot\n", "Rusty Dagger\n", "throwwing knifes\n", "seax\n" };
            Menu weapontwoeselect = new Menu(prompt, options);
            int selectedIndex = weapontwoeselect.Run();
            switch (selectedIndex)
            {
                case 0:
                    weapontwoeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponTwo = "Slingshot";
                    Program.playerStats.weaponTwoDamage = rnd.Next(5, 11);
                    Program.playerStats.attackspeedTwo = rnd.Next(0, 3);
                    Console.Clear();
                    Room();
                    break;

                case 1:
                    weapontwoeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponTwo = "Rusty Dagger";
                    Program.playerStats.weaponTwoDamage = rnd.Next(6, 13);
                    Program.playerStats.attackspeedTwo = rnd.Next(2, 5);
                    Console.Clear();
                    Room();
                    break;

                case 2:
                    weapontwoeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponTwo = "throwwing knifes";
                    Program.playerStats.weaponTwoDamage = rnd.Next(8, 11);
                    Program.playerStats.attackspeedTwo = rnd.Next(3, 8);
                    Console.Clear();
                    Room();
                    break;

                case 3:
                    weapontwoeselect.DisplaySelected();
                    System.Threading.Thread.Sleep(900);
                    Program.playerStats.weaponTwo = "seax";
                    Program.playerStats.weaponTwoDamage = rnd.Next(12, 18);
                    Program.playerStats.attackspeedTwo = rnd.Next(2, 6);
                    Console.Clear();
                    Room();
                    break;
            }
        }

        public void Escape()
        {
            float l = 0;
            float c = 0;

            Console.Clear();
            Program.util.statsPlayer();
            l = MathF.Round(rnd.Next(0, 100));
            c = MathF.Round(rnd.Next(0, 91));
            Program.util.CenterText($"You have a {c}% chance to escape");
            System.Threading.Thread.Sleep(1900);
            if (l < c)
            {
                Program.util.CenterText(" You did it you escaped");
                System.Threading.Thread.Sleep(1900);
                Program.util.CenterText("you go to a random door");
                System.Threading.Thread.Sleep(1900);
                Room();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string text = "you failed to escape";
                string prompt = "What do you do?.\n\n";
                Console.ResetColor();
                string[] options = { "Retry\n", "Give up (End game)" };
                Menu escape = new Menu(text, prompt, options);
                int selectedIndex = escape.Run();
                switch (selectedIndex)
                {
                    case 0:

                        System.Threading.Thread.Sleep(900);
                        Escape();
                        break;

                    case 1:
                        GiveUp();
                        break;
                }
            }
        }

        public void flee()
        {
            float l = 0;
            float c = 0;

            Console.Clear();
            Program.util.statsPlayer();
            l = MathF.Round(rnd.Next(0, 100));
            c = MathF.Round(rnd.Next(0, 96));
            Program.util.CenterText($"You have a {c}% chance to escape");
            System.Threading.Thread.Sleep(1900);
            if (l < c)
            {
                Program.util.CenterText(" You did it you escaped");
                System.Threading.Thread.Sleep(1900);
                Program.util.CenterText("you go to a random door");
                System.Threading.Thread.Sleep(1900);
                Room();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.util.CenterText("You failed and the Enemy's noticed you! Prepare to fight.");
                System.Threading.Thread.Sleep(1900);
                Combat();
            }
        }

        public void Combat()
        {
            Console.Clear();
            tempOptions2.Clear();
            enemy1 = "";
            enemy2 = "";
            enemy3 = "";
            float tempprot = (float)Program.playerStats.protection;
            float tempDamage;
            switch (Program.roomgen.monster)
            {
                case 1:
                    enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                    enemy2 = "";
                    enemy3 = "";
                    tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                    break;

                case 2:
                    enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                    enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                    enemy3 = "";
                    tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                    tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                    break;

                case 3:
                    enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                    enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                    enemy3 = Program.roomgen.enemy3.type + " (" + Program.roomgen.enemy3.health + " hp)  wielding a " + Program.roomgen.enemy3.weapon + " with the stats " + Program.roomgen.enemy3.damage + " dmg and " + Program.roomgen.enemy3.attackspeed + " speed";
                    tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                    tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                    tempOptions2.Add(Program.roomgen.enemy3.type + "\n");
                    break;
            }
            string text = "so you going to battle the enemy's. there are ";
            string text2 = enemy1;
            string text3 = enemy2;
            string text4 = enemy3;
            string prompt = "who you gonna attack?";
            string prompt2 = "Choose carfully";
            string[] options = tempOptions2.ToArray();
            Menu Combatsetup = new Menu(text, text2, text3, text4, prompt, prompt2, options);
            int selectedIndex = Combatsetup.Run();
            switch (selectedIndex)
            {
                case 0:
                    string Prompt = "with what weapon do you fight";
                    string[] choise = { Program.playerStats.weaponOne + "\n", Program.playerStats.weaponTwo + "\n" };
                    Menu selectwepon = new Menu(Prompt, choise);
                    int selectendex = selectwepon.Run();
                    tempDamage = Program.roomgen.enemy1.damage;
                    float enemy1Damage = tempDamage - (tempprot / 100);
                    switch (selectendex)
                    {
                        case 0:
                            if (Program.roomgen.enemy1.attackspeed > Program.playerStats.attackspeedOne)
                            {
                                Program.playerStats.health -= (int)enemy1Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy1.health -= Program.playerStats.weaponOneDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy1.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy1Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy1.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy1.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy1.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy1.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy1.health -= Program.playerStats.weaponOneDamage;
                                if (Program.roomgen.enemy1.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy1.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                Program.playerStats.health -= (int)enemy1Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy1.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy1Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy1.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy1.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;

                        case 1:
                            if (Program.roomgen.enemy1.attackspeed > Program.playerStats.attackspeedTwo)
                            {
                                Program.playerStats.health -= (int)enemy1Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy1.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy1.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy1Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy1.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy1.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy1.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems out in aggeny and lays awfully still. you think he's dead, his companions are frightend of you and step out the way");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy1.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy1.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.roomgen.enemy1.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems out in aggeny and lays awfully still. you think he's dead, his companions are frightend of you and step out the way");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy1.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                Program.playerStats.health -= (int)enemy1Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy1.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy1Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy1.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy1.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;
                    }
                    break;

                case 1:
                    string PRompt = "with what weapon do you fight";
                    string[] Choise = { Program.playerStats.weaponOne, Program.playerStats.weaponTwo };
                    Menu selEctwepon = new Menu(PRompt, Choise);
                    int Selectendex = selEctwepon.Run();
                    tempDamage = Program.roomgen.enemy2.damage;
                    float enemy2Damage = tempDamage - (tempprot / 100);
                    switch (Selectendex)
                    {
                        case 0:
                            if (Program.roomgen.enemy2.attackspeed > Program.playerStats.attackspeedOne)
                            {
                                Program.playerStats.health -= (int)enemy2Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy2.health -= Program.playerStats.weaponOneDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy2.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy2Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy2.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy2.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy2.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems out in aggeny and lays awfully still. you think he's dead, his companions are frightend of you and step out the way");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy2.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy2.health -= Program.playerStats.weaponOneDamage;
                                if (Program.roomgen.enemy2.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems out in aggeny and lays awfully still. you think he's dead, his companions are frightend of you and step out the way");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy2.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                Program.playerStats.health -= (int)enemy2Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy2.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy2Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy2.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy2.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;

                        case 1:
                            if (Program.roomgen.enemy2.attackspeed > Program.playerStats.attackspeedTwo)
                            {
                                Program.playerStats.health -= (int)enemy2Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy2.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy2.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy2Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy2.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy2.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy2.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems out in aggeny and lays awfully still. you think he's dead, his companions are frightend of you and step out the way");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy2.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy2.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.roomgen.enemy2.health <= 0 && Program.roomgen.monster == 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy2.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                else
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy2.type + " lifeless body and get ready to fight the other monster");
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                Program.playerStats.health -= (int)enemy2Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy2.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy2Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy2.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy2.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;
                    }
                    break;

                case 2:
                    string PrompT = "with what weapon do you fight";
                    string[] choisE = { Program.playerStats.weaponOne, Program.playerStats.weaponTwo };
                    Menu selectwepoN = new Menu(PrompT, choisE);
                    int selectendeX = selectwepoN.Run();
                    tempDamage = Program.roomgen.enemy3.damage;
                    float enemy3Damage = tempDamage - (tempprot / 100);
                    switch (selectendeX)
                    {
                        case 0:
                            if (Program.roomgen.enemy3.attackspeed > Program.playerStats.attackspeedOne)
                            {
                                Program.playerStats.health -= (int)enemy3Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy3.health -= Program.playerStats.weaponOneDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy3.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy3Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy3.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy3.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy3.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy3.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy3.health -= Program.playerStats.weaponOneDamage;
                                if (Program.roomgen.enemy3.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy3.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                Program.playerStats.health -= (int)enemy3Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy3.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy3Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy3.type + " sufferd " + Program.playerStats.weaponOneDamage + " damage its hp is now " + Program.roomgen.enemy3.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;

                        case 1:
                            if (Program.roomgen.enemy3.attackspeed > Program.playerStats.attackspeedTwo)
                            {
                                Program.playerStats.health -= (int)enemy3Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                Program.roomgen.enemy3.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.playerStats.health > 0 && Program.roomgen.enemy3.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy3Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy3.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy3.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                                else if (Program.roomgen.enemy3.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy3.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                            }
                            else
                            {
                                Program.roomgen.enemy3.health -= Program.playerStats.weaponTwoDamage;
                                if (Program.roomgen.enemy3.health <= 0)
                                {
                                    Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems out in aggeny and lays awfully still. you think he's dead");
                                    Program.util.CenterText(" You step over the " + Program.roomgen.enemy3.type + " lifeless body and pick a random door");
                                    System.Threading.Thread.Sleep(1500);
                                    Room();
                                }
                                Program.playerStats.health -= (int)enemy3Damage;
                                if (Program.playerStats.health <= 0)
                                {
                                    Death();
                                }
                                else if (Program.playerStats.health > 0 && Program.roomgen.enemy3.health > 0)
                                {
                                    Program.util.CenterText("You sufferd " + (int)enemy3Damage + " damage");
                                    Program.util.CenterText(Program.roomgen.enemy3.type + " sufferd " + Program.playerStats.weaponTwoDamage + " damage its hp is now " + Program.roomgen.enemy3.health);
                                    System.Threading.Thread.Sleep(1500);
                                    Combat();
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        public void Death()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Program.util.CenterText("Your dead! Go cry about it!, hope to see you again ;-)");
            Program.util.CenterText("Your score was: " + room);
            System.Threading.Thread.Sleep(2500);
            Environment.Exit(0);
        }

        public void GiveUp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Program.util.CenterText("You Gave up how sadd, hope to see you again");
            Program.util.CenterText("Your score was: " + room);
            System.Threading.Thread.Sleep(2500);
            Environment.Exit(0);
        }

        public void Room()
        {
            Console.Clear();
            if (!rest)
            {
                if (Program.playerStats.XP < Program.playerStats.XPcap)
                {
                    Program.playerStats.XP += (Program.playerStats.XPboost * rnd.Next(0, 3));
                }
                if (Program.playerStats.health < Program.playerStats.maxhealth)
                {
                    Program.playerStats.health += Program.playerStats.pasiveHealing;
                    Program.util.CenterText($"You healed {Program.playerStats.pasiveHealing}HP");
                }

                room++;
                tempText = "";
                tempText2 = "";
                tempText3 = "";
                tempText4 = "";
                Program.roomgen.Generate();
                tempOptions.Clear();

                currentRoom = Program.roomgen.roomStyle;
                switch (Program.roomgen.roomStyle)
                {
                    case 0:
                        for (int i = 0; i < Program.roomgen.exits; i++)
                        {
                            j = i + 1;
                            tempOptions.Add("Go through door " + j + "\n");
                        }
                        break;

                    case 1:
                        tempOptions.Add("Try to escape\n");
                        tempOptions.Add("Give up (End game)\n");
                        break;

                    case 2:
                        tempOptions.Add("Try to flee\n");
                        tempOptions.Add("Attack the Enemy's\n");
                        if (Program.playerStats.sneak)
                        {
                            tempOptions.Add("Sneak Attack (special attack - 1");
                        }
                        else if (Program.playerStats.heavy)
                        {
                            tempOptions.Add("Heavy Attack (special attack - 1");
                        }
                        tempOptions.Add("Surrender (End game)\n");
                        break;

                    case 3:
                        tempOptions.Add("Go Down the stairs");
                        tempOptions.Add("take a rest");
                        break;
                }
            }
            else
            {
                if (Program.playerStats.XP < Program.playerStats.XPcap)
                {
                    Program.playerStats.XP += (Program.playerStats.XPboost * rnd.Next(0, 3));
                }
                if (Program.playerStats.health < Program.playerStats.maxhealth)
                {
                    Program.playerStats.health += Program.playerStats.pasiveHealing;
                    Program.util.CenterText($"You healed {Program.playerStats.pasiveHealing}HP");
                }

                tempOptions.Clear();

                currentRoom = Program.roomgen.roomStyle;
                switch (Program.roomgen.roomStyle)
                {
                    case 0:
                        tempOptions.Add("Take a Rest");
                        for (int i = 0; i < Program.roomgen.exits; i++)
                        {
                            j = i + 1;
                            tempOptions.Add("Go through door " + j + "\n");
                        }
                        break;

                    case 1:
                        tempOptions.Add("Try to escape\n");
                        tempOptions.Add("Give up (End game)\n");
                        break;

                    case 2:
                        tempOptions.Add("Try to flee\n");
                        tempOptions.Add("Attack the Enemy's\n");
                        if (Program.playerStats.sneak)
                        {
                            tempOptions.Add("Sneak Attack (special attack - 1");
                        }
                        else if (Program.playerStats.heavy)
                        {
                            tempOptions.Add("Heavy Attack (special attack - 1");
                        }
                        tempOptions.Add("Surrender (End game)\n");
                        break;

                    case 3:
                        tempOptions.Add("Go Down the stairs");
                        tempOptions.Add("take a rest");
                        break;
                }
            }
            Program.util.Break();
            Program.util.Break();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string temptext = tempText;
            string text = temptext;
            string temptext2 = tempText2;
            string text2 = temptext2;
            string temptext3 = tempText3;
            string text3 = temptext3;
            string temptext4 = tempText4;
            string text4 = temptext4;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string prompt = "What wil you do now?\n";
            string prompt2 = "These are your options.\n";
            Console.ResetColor();
            string[] tempoptions = tempOptions.ToArray();
            string[] options = tempoptions;
            Menu Options = new Menu(text, text2, text3, text4, prompt, prompt2, options);
            int selectedIndex = Options.Run();
            switch (Program.roomgen.roomStyle)
            {
                case 0:
                    switch (selectedIndex)
                    {
                        case 0:
                            Options.DisplayOptions();
                            System.Threading.Thread.Sleep(900);
                            rest = true;
                            Room();
                            break;

                        case 1:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            Console.Clear();
                            Program.util.CenterText("You continu thru door " + (selectedIndex + 1));
                            rest = false;
                            System.Threading.Thread.Sleep(1900);
                            Room();
                            break;

                        case 2:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            Console.Clear();
                            Program.util.CenterText("You continu thru door " + (selectedIndex + 1));
                            rest = false;
                            System.Threading.Thread.Sleep(1900);
                            Room();
                            break;

                        case 3:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            Console.Clear();
                            Program.util.CenterText("You continu thru door " + (selectedIndex + 1));
                            System.Threading.Thread.Sleep(1900);
                            rest = false;
                            Room();
                            break;
                    }
                    break;

                case 1:
                    switch (selectedIndex)
                    {
                        case 0:

                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            Console.Clear();
                            Escape();

                            break;

                        case 1:
                            GiveUp();
                            break;
                    }
                    break;

                case 2:
                    switch (selectedIndex)
                    {
                        case 0:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            flee();
                            break;

                        case 1:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            Combat();
                            break;

                        case 2:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            SpecialAttack();
                            break;

                        case 3:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            GiveUp();
                            break;
                    }
                    break;

                case 3:
                    switch (selectedIndex)
                    {
                        case 0:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            rest = false;
                            Room();
                            break;

                        case 1:
                            Options.DisplaySelected();
                            System.Threading.Thread.Sleep(900);
                            rest = true;
                            Room();
                            break;
                    }
                    break;
            }
        }

        public void SpecialAttack()
        {
            if (Program.playerStats.heavy)
            {
                Console.Clear();
                tempOptions2.Clear();
                enemy1 = "";
                enemy2 = "";
                enemy3 = "";
                switch (Program.roomgen.monster)
                {
                    case 1:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = "";
                        enemy3 = "";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        break;

                    case 2:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                        enemy3 = "";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                        break;

                    case 3:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                        enemy3 = Program.roomgen.enemy3.type + " (" + Program.roomgen.enemy3.health + " hp)  wielding a " + Program.roomgen.enemy3.weapon + " with the stats " + Program.roomgen.enemy3.damage + " dmg and " + Program.roomgen.enemy3.attackspeed + " speed";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy3.type + "\n");
                        break;
                }
                string text = "so you going to do a heavy attack on the enemy's. there are ";
                string text2 = enemy1;
                string text3 = enemy2;
                string text4 = enemy3;
                string prompt = "who you gonna attack?";
                string prompt2 = "Choose carfully";
                string[] options = tempOptions2.ToArray();
                Menu Combatsetup = new Menu(text, text2, text3, text4, prompt, prompt2, options);
                int selectedIndex = Combatsetup.Run();
                float temphealth = 0;
                int DAMAGE = 0;
                switch (selectedIndex)
                {
                    case 0:
                        temphealth = (float)Program.roomgen.enemy1.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.68f);
                        Program.roomgen.enemy1.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems and gets " + DAMAGE + " damage");
                        Program.util.CenterText("You sufferd " + rnd.Next(5, 16) + " damage from the impact of your heavy attack");
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();

                        break;

                    case 1:
                        temphealth = (float)Program.roomgen.enemy2.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.68f);
                        Program.roomgen.enemy1.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems and gets " + DAMAGE + " damage");
                        Program.util.CenterText("You sufferd " + rnd.Next(5, 16) + " damage from the impact of your heavy attack");
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();

                        break;

                    case 2:
                        temphealth = (float)Program.roomgen.enemy3.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.68f);
                        Program.roomgen.enemy1.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems and gets " + DAMAGE + " damage");
                        Program.util.CenterText("You sufferd " + rnd.Next(5, 16) + " damage from the impact of your heavy attack");
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();

                        break;
                }
            }
            else if (Program.playerStats.sneak)
            {
                Console.Clear();
                tempOptions2.Clear();
                enemy1 = "";
                enemy2 = "";
                enemy3 = "";
                switch (Program.roomgen.monster)
                {
                    case 1:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = "";
                        enemy3 = "";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        break;

                    case 2:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                        enemy3 = "";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                        break;

                    case 3:
                        enemy1 = Program.roomgen.enemy1.type + " (" + Program.roomgen.enemy1.health + " hp)  wielding a " + Program.roomgen.enemy1.weapon + " with the stats " + Program.roomgen.enemy1.damage + " dmg and " + Program.roomgen.enemy1.attackspeed + " speed";
                        enemy2 = Program.roomgen.enemy2.type + " (" + Program.roomgen.enemy2.health + " hp)  wielding a " + Program.roomgen.enemy2.weapon + " with the stats " + Program.roomgen.enemy2.damage + " dmg and " + Program.roomgen.enemy2.attackspeed + " speed";
                        enemy3 = Program.roomgen.enemy3.type + " (" + Program.roomgen.enemy3.health + " hp)  wielding a " + Program.roomgen.enemy3.weapon + " with the stats " + Program.roomgen.enemy3.damage + " dmg and " + Program.roomgen.enemy3.attackspeed + " speed";
                        tempOptions2.Add(Program.roomgen.enemy1.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy2.type + "\n");
                        tempOptions2.Add(Program.roomgen.enemy3.type + "\n");
                        break;
                }
                string text = "so you going to sneak-up to the enemy's. there are ";
                string text2 = enemy1;
                string text3 = enemy2;
                string text4 = enemy3;
                string prompt = "who you gonna attack?";
                string prompt2 = "Choose carfully";
                string[] options = tempOptions2.ToArray();
                Menu Combatsetup = new Menu(text, text2, text3, text4, prompt, prompt2, options);
                int selectedIndex = Combatsetup.Run();
                float temphealth = 0;
                int DAMAGE = 0;
                switch (selectedIndex)
                {
                    case 0:
                        temphealth = (float)Program.roomgen.enemy1.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.79f);
                        Program.roomgen.enemy1.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy1.type + " screems of suprise and gets " + DAMAGE + " damage");
                        int i = rnd.Next(0, 3);
                        Program.util.CenterText("the Enemy's attackspeed goes up by " + i + " because he's more alert since you sneaked up to him");
                        Program.roomgen.enemy1.attackspeed += i;
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();
                        break;

                    case 1:
                        temphealth = (float)Program.roomgen.enemy2.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.79f);
                        Program.roomgen.enemy2.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy2.type + " screems of suprise and gets " + DAMAGE + " damage");
                        int j = rnd.Next(0, 3);
                        Program.util.CenterText("the Enemy's attackspeed goes up by " + j + " because he's more alert since you sneaked up to him");
                        Program.roomgen.enemy2.attackspeed += j;
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();
                        break;

                    case 2:
                        temphealth = (float)Program.roomgen.enemy3.health;
                        DAMAGE = (int)MathF.Round(temphealth * 0.79f);
                        Program.roomgen.enemy3.health -= DAMAGE;
                        Program.util.CenterText("The " + Program.roomgen.enemy3.type + " screems of suprise and gets " + DAMAGE + " damage");
                        int k = rnd.Next(0, 3);
                        Program.util.CenterText("the Enemy's attackspeed goes up by " + k + " because he's more alert since you sneaked up to him");
                        Program.roomgen.enemy3.attackspeed += k;
                        Program.util.CenterText("You prepare to continu the fight!");
                        System.Threading.Thread.Sleep(1500);
                        Combat();
                        break;
                }
            }
        }
    }
}