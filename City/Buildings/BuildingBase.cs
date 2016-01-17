namespace City.Buildings
{
    using Contracts;
    using Exceptions;

    public abstract class BuildingBase : IBuilding
    {
        protected BuildingBase(int capacity)
        {
            this.Capacity = capacity;
            this.OccupiedCapacity = 0;
        }

        public int Capacity { get; private set; }

        public int OccupiedCapacity { get; set; }

        public int FreeCapacity
        {
            get
            {
                return this.Capacity - this.OccupiedCapacity;
            }
        }

        public void Populate(int persons)
        {
            if (this.FreeCapacity < persons)
            {
                throw new NotEnoughBuildingCapacity($"This building does not have anough cappacity to accommodate {persons} persons.");
            }

            this.OccupiedCapacity += persons;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} with capacity of {this.Capacity} (Free: {this.FreeCapacity}).";
        }
    }
}