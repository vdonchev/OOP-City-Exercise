namespace City
{
    using Contracts;
    using Core;
    using IO;

    public static class CityMain
    {
        public static void Main()
        {
            ICity city = new City();
            IRenderer renderer = new ConsoleRenderer();
            IWriter writer = new ConsoleWriter();
            
            ICityBuilder cityBuilder = new CityBuilder(
                city,
                renderer,
                writer);

            cityBuilder.Run();
        }
    }
}
