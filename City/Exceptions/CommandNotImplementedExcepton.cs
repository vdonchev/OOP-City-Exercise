namespace City.Exceptions
{
    public class CommandNotImplementedExcepton : CityException
    {
        public CommandNotImplementedExcepton(string msg) 
            : base(msg)
        {
        }
    }
}