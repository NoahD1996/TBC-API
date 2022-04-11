namespace Tarkov_Ballistics_Calculator.Models
{
    public class Armor
    {
        public long Id { get; set; }
        public int MaxDurability { get; set; }
        public int CurrentDurability { get; set; }
        public int ClassScore { get => Level * 10; }
        public int Level { get; set; }
        public string? Material { get; set; }
        public float Destructibility { get; set; }
    }
}

