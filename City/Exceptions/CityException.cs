namespace City.Exceptions
{
    using System;

    public abstract class CityException : Exception
    {
        protected CityException(string msg)
            : base(msg)
        {
        }
    }
}