using System;

namespace DiggersAndFliers
{
    public class BettaFish : IUnderWater
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int DiveSpeed { get; set; }
        public int SwimSpeed { get; set; }

        public void Dive()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now diving.");
        }
        public void Swim()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now swimming.");
        }
        public void Surface()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now surfacing.");
        }
        public override string ToString()
        {
            return $"The {Name} can swim at a rate of {SwimSpeed} inches per min. It can dive down at a rate of {DiveSpeed} inches per min.";
        }
    }
}