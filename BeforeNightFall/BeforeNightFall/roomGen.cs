using System;

namespace BeforeNightFall
{
    internal class roomGen
    {
        public string[] types = new string[] { "empty room", "trap room", "enemy room", "stairs" };
        public string[] mosters = new string[] { "giant", "drak elf", "gnome", "bandit", "rouge", "humaanoid raptile" };
        public string[] weapons = new string[] { "spaer", "broadsword", "crossbow", "pike", "dagger", "sword", "hammer", "bat" };
        public int exits;
        private Random rnd = new Random();
        public int roomStyle;
        public int monster;
        public Constructor enemy1;
        public Constructor enemy2;
        public Constructor enemy3;
        public int maxMonsterHealth = 20;

        public void Generate()
        {
            roomStyle = rnd.Next(0, 3);
            exits = rnd.Next(1, 4);
            monster = rnd.Next(1, 4);

            if (Program.myGame.room > 10)
            {
                roomStyle = 3;
                maxMonsterHealth += 12;
            }
            switch (roomStyle)
            {
                case 0:

                    Program.myGame.tempText = "you enter a " + types[roomStyle] + " there are " + exits + " doors the room only got those doors";
                    Program.myGame.tempText2 = "there are " + exits + " doors";
                    Program.myGame.tempText3 = "the room only got those doors";
                    break;

                case 1:

                    Program.myGame.tempText = "you enter a " + types[roomStyle] + " there are " + exits + " doors the room only got those doors";
                    Program.myGame.tempText2 = "there are " + exits + " doors";
                    Program.myGame.tempText3 = "ohh no! you fel into a trap room";

                    break;

                case 2:

                    Program.myGame.tempText = "you enter a " + types[roomStyle] + " there are " + exits + " doors the room only got those doors";
                    Program.myGame.tempText2 = "there are " + exits + " doors";
                    Program.myGame.tempText3 = "you enterd a room with " + monster + " monsters!";
                    switch (monster)
                    {
                        case 1:
                            enemy1 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            Program.myGame.tempText4 = "There is a " + enemy1.type + " with " + enemy1.health + " health holding a " + enemy1.weapon + " with " + enemy1.damage + " damage and " + enemy1.attackspeed + " attackspeed";
                            break;

                        case 2:
                            enemy1 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            enemy2 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            Program.myGame.tempText4 = "There is a " + enemy1.type + " with " + enemy1.health + " health holding a " + enemy1.weapon + " with " + enemy1.damage + " damage and " + enemy1.attackspeed + " attackspeed\n" + "There is a " + enemy2.type + " with " + enemy2.health + " health holding a " + enemy2.weapon + " with " + enemy2.damage + " damage and " + enemy2.attackspeed + " attackspeed";
                            break;

                        case 3:
                            enemy1 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            enemy2 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            enemy3 = new Constructor(rnd.Next(15, maxMonsterHealth), mosters[rnd.Next(0, 6)], rnd.Next(0, 9), rnd.Next(2, 46), weapons[rnd.Next(0, 8)]);
                            Program.myGame.tempText4 = "There is a " + enemy1.type + " with " + enemy1.health + " health holding a " + enemy1.weapon + " with " + enemy1.damage + " damage and " + enemy1.attackspeed + " attackspeed\n" + "There is a " + enemy2.type + " with " + enemy2.health + " health holding a " + enemy2.weapon + " with " + enemy2.damage + " damage and " + enemy2.attackspeed + " attackspeed\n" + "There is a " + enemy3.type + " with " + enemy3.health + " health holding a " + enemy3.weapon + " with " + enemy3.damage + " damage and " + enemy3.attackspeed + " attackspeed";
                            break;
                    }
                    break;

                case 3:
                    Program.myGame.tempText = $"you enter a room with { types[roomStyle]}";
                    Program.myGame.tempText2 = "you can go down the stairs or take a rest";
                    Program.myGame.tempText3 = "";
                    break;
            }
        }
    }
}