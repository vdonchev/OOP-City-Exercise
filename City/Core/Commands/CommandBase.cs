namespace City.Core.Commands
{
    using Contracts;

    public abstract class CommandBase : ICommand
    {
        protected CommandBase(ICityBuilder cityBuilder)
        {
            this.CityBuilder = cityBuilder;
        }

        public ICityBuilder CityBuilder { get; private set; }

        public abstract void Execute(params string[] args);
    }
}