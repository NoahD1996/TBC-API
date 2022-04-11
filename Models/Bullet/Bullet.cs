namespace Tarkov_Ballistics_Calculator.Models
{
    public class Bullet
    {
        public long Id { get; set; }
        public int Damage { get; set; }
        public int Penetration { get; set; }
        public float ArmorDamage { get; set; }
        public float FragementationChance { get; set; }
    }
}

