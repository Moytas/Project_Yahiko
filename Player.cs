namespace Project_Yahiko
{
    public class Player : Character
    {
        public string FirstName, LastName;
        public int PlayerClass;
        public Weapon EquipedWeapon;
        public Armor EquipedArmor;
        public int XP, XPToNext;
        public Player()
        {
            CharacterStats = new Stats();
            EquipedWeapon = new Weapon();
            EquipedArmor = new Armor();
           
        }
    }
}