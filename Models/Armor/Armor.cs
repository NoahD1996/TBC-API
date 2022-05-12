namespace Tarkov_Ballistics_Calculator.Models
{
    public class Armor
    {
        public long Id { get; set; }
        public string? ArmorName { get; set; }
        public long MaxDurability { get; set; }
        public long ClassScore { get => Level * 10; }
        public long Level { get; set; }
        public string? Material { get; set; }
        public double Destructibility { get; set; }
        public string? Zones { get; set; }
        public double MovementSpeed { get; set; }
        public double TurnSpeed { get; set; }
        public long Ergonomics { get; set; }
        public double Weight { get; set; }
    }
}

