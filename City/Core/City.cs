namespace City.Core
{
    using System.Collections.Generic;
    using System.Linq;
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

        public int TotalCapacity
        {
            get
            {
                return this.buildings.Sum(b => b.Capacity);
            }
        }

        public int OccupiedCapacity
        {
            get
            {
                return this.buildings.Sum(b => b.OccupiedCapacity);
            }
        }

        public int FreeCapacity
        {
            get
            {
                return this.buildings.Sum(b => b.FreeCapacity);
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