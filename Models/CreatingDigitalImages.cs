using System.Resources;
using System.Security.Policy;

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models
{
    public class CreatingDigitalImages
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ResourcesId { get; set; }
        public int GraphicProductId { get; set; }
        public int EvidenceId { get; set; }
        public virtual ICollection<Resources>? Resources { get; set; }
        public virtual ICollection<Evidence>? Evidence { get; set; }
        public virtual ICollection<GraphicProducts>? GraphicProducts { get; set; }
    }
}
