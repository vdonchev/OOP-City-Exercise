namespace City.Buildings
{
    using Attributes;

    [Building]
    public class Apartament : BuildingBase
    {
        private const int ApartamentDefaultCapacity = 3;

        public Apartament(int capacity) 
            : base(capacity)
        {
        }

        public Apartament()
            : this(ApartamentDefaultCapacity)
        {
        }
    }
}