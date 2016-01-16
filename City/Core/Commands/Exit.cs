namespace City.Core.Commands
{
    using Attributes;
    using Contracts;

    [Command]
    public class Exit : CommandBase
    {
        public Exit(ICityBuilder cityBuilder) 
            : base(cityBuilder)
        {
        }

        public override void Execute(params string[] args)
        {
            this.CityBuilder.IsRunning = false;
        }
    }
}