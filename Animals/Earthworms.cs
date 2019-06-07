using System;

namespace DiggersAndFliers
{
    public class Earthworms : IUnderGround, IAboveGround
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int DigSpeed { get; set; }
        public int RunSpeed { get; set; }
        public int WalkSpeed { get; set; }

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
        public override string ToString()
        {
            return $"The {Name} can dig at a rate of {DigSpeed} inches per min. It can walk at a rate of {WalkSpeed} inches per min and run at a rate of {RunSpeed} inches per min.";
        }
    }
}