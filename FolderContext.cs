using Microsoft.EntityFrameworkCore;
using TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models;

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi
{
    public class FolderContext : DbContext
    {
        public FolderContext(DbContextOptions<FolderContext> options) : base(options)
        {
        }
        public DbSet<CreatingDigitalImages> CreatingDigitalImages { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<PrimarySources> PrimarySources { get; set; }
        public DbSet<SecondarySources> SecondarySources { get; set; }
        public DbSet<Evidence> Evidence { get; set; }
        public DbSet<GraphicProducts> GraphicProducts { get; set; }
        public DbSet<FinalProduct> FinalProducts { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
