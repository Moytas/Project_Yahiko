namespace Project_Yahiko
{
    public class Player : Character
    {
        public string FirstName, LastName;
        public Weapon EquipedWeapon;
        public Player()
        {
            CharacterStats = new Stats();
            EquipedWeapon = new Weapon();
           
        }
    }
}