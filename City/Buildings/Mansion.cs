namespace City.Buildings
{
    using Attributes;

    [Building]
    public class Mansion : BuildingBase
    {
        private const int MansionDefaultCapacity = 10;

        public Mansion(int capacity) 
            : base(capacity)
        {
        }

        public Mansion()
            : this(MansionDefaultCapacity)
        {
        }
    }
}