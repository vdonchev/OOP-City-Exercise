namespace City.Exceptions
{
    public class BuildingNotImplementedExcepton : CityException
    {
        public BuildingNotImplementedExcepton(string msg) 
            : base(msg)
        {
        }
    }
}