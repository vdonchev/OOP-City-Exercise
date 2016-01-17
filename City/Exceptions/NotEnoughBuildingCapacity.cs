namespace City.Exceptions
{
    public class NotEnoughBuildingCapacity : CityException
    {
        public NotEnoughBuildingCapacity(string msg) 
            : base(msg)
        {
        }
    }
}