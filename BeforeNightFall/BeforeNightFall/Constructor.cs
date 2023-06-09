namespace BeforeNightFall
{
    public class Constructor
    {
        public int health;
        public string type;
        public int attackspeed;
        public int damage;
        public string weapon;

        public Constructor(int ihp, string stype, int iattackspeed, int idamage, string sweapon)
        {
            health = ihp;
            type = stype;
            attackspeed = iattackspeed;
            damage = idamage;
            weapon = sweapon;
        }
    }
}