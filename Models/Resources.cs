namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models
{
    public class Resources
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PrimaryResourcesId { get; set; }
        public int SecondaryResourcesId { get; set; }
        public virtual ICollection<PrimarySources>? PrimaryResources { get; set; }
        public virtual ICollection<SecondarySources>? SecondaryResources { get; set; }
    }
}
