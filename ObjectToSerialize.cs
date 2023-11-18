namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi
{
    public class ObjectToSerialize
    {
        private readonly List<object> _objectsToSerialize = new List<object>()
        {
            new Models.CreatingDigitalImages {},
            new Models.Evidence { },
            new Models.FinalProduct { },
            new Models.GraphicProducts { },
            new Models.PrimarySources { },
            new Models.SecondarySources { },
            new Models.Resources { },
            new Models.Process { }            
        };
        public List<object> ObjectsToSerialize => _objectsToSerialize;
    }
}
