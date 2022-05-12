namespace Tarkov_Ballistics_Calculator.Models
{
    public class Bullet
    {
        public long Id { get; set; }
        public string? BulletName { get; set;}
        public long Damage { get; set; }
        public long Penetration { get; set; }
        public double ArmorDamage { get; set; }
        public long Recoil { get; set; }
        public long Accuracy { get; set; }
        public double FragmentationChance { get; set; }
        public long ProjectileSpeed { get; set; }
        public double LightBleedingChance { get; set; }
        public double HeavyBleedingChance { get; set; }
        public double RicochetChance { get; set; }
    }
}

