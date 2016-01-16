namespace City.Contracts
{
    using System.Collections.Generic;

    public interface ICity
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);
    }
}