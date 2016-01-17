namespace City.Exceptions
{
    public class NotEnoughCityCapacity : CityException
    {
        public NotEnoughCityCapacity(string msg) 
            : base(msg)
        {
        }
    }
}