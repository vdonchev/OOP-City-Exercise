namespace City.Core.Commands
{
    using Attributes;
    using Contracts;
    using Exceptions;
    using Factories;

    [Command]
    public class Create : CommandBase
    {
        public Create(ICityBuilder cityBuilder) 
            : base(cityBuilder)
        {
        }

        public override void Execute(params string[] args)
        {
            var buildingName = args[1];

            try
            {
                var building = BuildingFactory.Build(buildingName);
                this.CityBuilder.City.AddBuilding(building);
            }
            catch (BuildingNotImplementedExcepton ex)
            {
                this.CityBuilder.Writer.Print(ex.Message);
            }
        }
    }
}