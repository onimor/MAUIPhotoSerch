using Microsoft.EntityFrameworkCore;

namespace MAUIPhotoSerch.Data;

public class ImagesDBContex : DbContext
{
    public DbSet<ImageEF> Images { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Path.Combine(FileSystem.AppDataDirectory, "appDB.db")}"); 
    }
    
}
