using System.Diagnostics;

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models
{
    public class GraphicProducts
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProcessId { get; set; }
        public int FinalProductId { get; set; }
        public virtual ICollection<Process>? Process { get; set; }
        public virtual ICollection<FinalProduct>? FinalProduct { get; set; }
    }
}
