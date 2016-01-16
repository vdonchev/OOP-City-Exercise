namespace City.Buildings
{
    using Attributes;

    [Building]
    public class House : BuildingBase
    {
        private const int HouseDefaultCapacity = 5;

        public House(int capacity)
            : base(capacity)
        {
        }
        
        public House()
            : this(HouseDefaultCapacity)
        {
        }
    }
}