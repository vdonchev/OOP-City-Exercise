namespace City.Core.Commands
{
    using System.Linq;
    using System.Text;
    using Attributes;
    using Contracts;

    [Command]
    public class Status : CommandBase
    {
        public Status(ICityBuilder cityBuilder) 
            : base(cityBuilder)
        {
        }

        public override void Execute(params string[] args)
        {

            var result = new StringBuilder();
            result.AppendLine("Buildings:");

            if (this.CityBuilder.City.Buildings.Any())
            {
                foreach (var building in this.CityBuilder.City.Buildings)
                {
                    result.AppendLine($"---{building}");
                }
            }
            else
            {
                result.AppendLine("N/A");
            }

            this.CityBuilder.Writer.Print(result.ToString().Trim());
        }
    }
}