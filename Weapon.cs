namespace Project_Yahiko
{
    public class Weapon : Items
    {
        public int MinDamageSmall { get; set; }
        public int MaxDamageSmall { get; set; }
        public int MinDamageLarge { get; set; }
        public int MaxDamageLarge { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }

        public Weapon()
        {
            Name = "Unarmed";
            MinDamageSmall = 1;
            MaxDamageSmall = 3;
            MinDamageLarge = 1;
            MaxDamageLarge = 2;
            Speed = 3;
            Type = "B";
        }
    }
}