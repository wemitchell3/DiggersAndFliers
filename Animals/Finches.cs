using System;

namespace DiggersAndFliers
{
    public class Finches : IUnderWater, IAboveGround, IFlyAboveGround
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int DiveSpeed { get; set; }
        public int SwimSpeed { get; set; }
        public int RunSpeed { get; set; }
        public int WalkSpeed { get; set; }
        public int FlightSpeed { get; set; }
        public int FlyDiveSpeed { get; set; }

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
        public void Run()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now Running.");
        }
        public void Walk()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now walking.");
        }
        public void TakeOff()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now taking off.");
        }
        public void Land()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now landing.");
        }
        public override string ToString()
        {
            return $"The {Name} can fly at a rate of {FlightSpeed} feet per sec and dive at a rate of {FlyDiveSpeed} feet per second. It can walk at a rate of {WalkSpeed} inches per min and run at a rate of {RunSpeed} inches per min. Also, it can swim at a rate of {SwimSpeed} inches per min. It can dive down at a rate of {DiveSpeed} inches per min.";
        }
    }
}