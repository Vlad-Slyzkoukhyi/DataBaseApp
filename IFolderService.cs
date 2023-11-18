using Microsoft.EntityFrameworkCore;

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi
{
    public interface IFolderService
    {
        public DbSet<FolderContext> Entities { get; set; }
    }
}
