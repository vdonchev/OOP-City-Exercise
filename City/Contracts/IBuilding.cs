namespace City.Contracts
{
    public interface IBuilding
    {
        int Capacity { get; } 

        int OccupiedCapacity { get; set; }

        int FreeCapacity { get; }

        void Populate(int persons);
    }
}