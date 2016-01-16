namespace City.Core
{
    using System.Collections.Generic;
    using Contracts;

    public class City : ICity
    {
        private readonly IList<IBuilding> buildings; 

        public City()
        {
            this.buildings = new List<IBuilding>();
        }

        public IEnumerable<IBuilding> Buildings
        {
            get
            {
                return this.buildings;
            }
        }

        public void AddBuilding(IBuilding building)
        {
            if (building != null)
            {
                this.buildings.Add(building);
            }
        }
    }
}