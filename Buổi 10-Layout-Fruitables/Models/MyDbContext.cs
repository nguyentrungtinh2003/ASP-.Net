using Microsoft.EntityFrameworkCore;

namespace Buổi_10_Layout_Fruitables.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext>

        options) : base(options) { }
    }
}
