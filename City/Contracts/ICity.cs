namespace City.Contracts
{
    using System.Collections.Generic;

    public interface ICity
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        int TotalCapacity { get; }

        int OccupiedCapacity { get; }

        int FreeCapacity { get; }
    }
}