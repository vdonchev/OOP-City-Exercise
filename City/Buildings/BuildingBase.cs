namespace City.Buildings
{
    using Contracts;

    public abstract class BuildingBase : IBuilding
    {
        protected BuildingBase(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} with capacity of {this.Capacity}.";
        }
    }
}