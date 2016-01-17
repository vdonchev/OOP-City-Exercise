namespace City.Core.Commands
{
    using System;
    using System.Linq;
    using Attributes;
    using Contracts;
    using Exceptions;

    [Command]
    public class Populate : CommandBase
    {
        public Populate(ICityBuilder cityBuilder)
            : base(cityBuilder)
        {
        }

        public override void Execute(params string[] args)
        {
            int personsToPopulate = int.Parse(args[1]);
            int personsToPopulateLeft = personsToPopulate;

            if (personsToPopulate <= 0)
            {
                throw new InvalidOperationException("Person's count should be bigger than 0.");
            }

            if (this.CityBuilder.City.FreeCapacity < personsToPopulate)
            {
                throw new NotEnoughCityCapacity(
                    $"The city does not have enough capacity to accommodate {personsToPopulate} persons.");
            }

            foreach (var building in this.CityBuilder.City.Buildings.Where(b => b.FreeCapacity > 0))
            {
                if (personsToPopulateLeft <= 0)
                {
                    break;
                }

                var personsToPopulateInBuilding =
                    Math.Min(building.FreeCapacity, personsToPopulateLeft);

                building.Populate(personsToPopulateInBuilding);
                personsToPopulateLeft -= personsToPopulateInBuilding;
            }

            this.CityBuilder.Writer.Print(
                $"{personsToPopulate} was accommodated sucessfully!");
        }
    }
}