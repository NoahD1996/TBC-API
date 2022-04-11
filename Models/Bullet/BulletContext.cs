using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Tarkov_Ballistics_Calculator.Models
{
    public class BulletContext : DbContext
    {
        public BulletContext(DbContextOptions<BulletContext> op)
            : base(op)
        {
        }

        public DbSet<Bullet> Bullets { get; set; } = null!;
    }
}