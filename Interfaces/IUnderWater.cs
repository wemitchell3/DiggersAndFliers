namespace DiggersAndFliers
{
    public interface IUnderWater
    {
        int SwimSpeed { get; set; }
        int DiveSpeed { get; set; }
        void Dive();
        void Swim();
        void Surface();
    }
}