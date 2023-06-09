namespace BeforeNightFall
{
    internal class playerstats
    {
        //player stats
        public string race;

        public string name;
        public int health = 100;
        public int maxhealth = 100;
        public float XP = 0;
        public int level = 0;
        public float XPcap = 50;
        public float XPboost = 2.5f;

        //player inventory
        public string armor = " Traveler clothes";

        public int protection = 25;

        public string weaponOne = " ";
        public int weaponOneDamage;
        public int attackspeedOne;

        public string weaponTwo = " ";
        public int weaponTwoDamage;
        public int attackspeedTwo;

        //special stats
        public int specialAttack = 2;

        public bool heavy;
        public bool sneak;
        public int pasiveHealing = 10;

        public void abbilety1(string title, bool locked)
        {
            if (!locked)
            {
                switch (title)
                {
                    case "":
                        break;

                    default:
                        break;
                }
            }
        }

        public void abbilety2(string title, bool locked)
        {
            if (!locked)
            {
                switch (title)
                {
                    case "":
                        break;

                    default:
                        break;
                }
            }
        }

        public void abbilety3(string title, bool locked)
        {
            if (!locked)
            {
                switch (title)
                {
                    case "":
                        break;

                    default:
                        break;
                }
            }
        }
    }
}