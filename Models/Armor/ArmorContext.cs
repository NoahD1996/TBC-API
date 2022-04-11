using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Tarkov_Ballistics_Calculator.Models
{
    public class ArmorContext : DbContext
    {
        public ArmorContext(DbContextOptions<ArmorContext> op)
            : base(op)
        {
        }

        public DbSet<Armor> Armor { get; set; } = null!;
    }
}