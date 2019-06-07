using System;

namespace DiggersAndFliers
{
    public class Mice : IUnderGround, IAboveGround, IUnderWater
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int DigSpeed { get; set; }
        public int RunSpeed { get; set; }
        public int WalkSpeed { get; set; }

        public int SwimSpeed { get; set; }
        public int DiveSpeed { get; set; }

        public void Dig()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now digging.");
        }
        public void Run()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now Running.");
        }
        public void Walk()
        {
            Console.WriteLine($"The {Name}, which is a {Type}, is now walking.");
        }
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
            return $"The {Name} can walk at a rate of {WalkSpeed} inches per min and run at a rate of {RunSpeed} inches per min. Also, it can swim at a rate of {SwimSpeed} inches per min. It can dive down at a rate of {DiveSpeed} inches per min. Also, it can dig at a rate of {DigSpeed} inches per min";
        }   
    }
}