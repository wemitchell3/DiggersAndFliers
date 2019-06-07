using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Ants ant = new Ants()
            {
                Name = "Fire Ant",
                Type = "Insect",
                DigSpeed = 10,
                WalkSpeed = 3,
                RunSpeed = 5
            };
            BettaFish bettaFish = new BettaFish()
            {
                Name = "Betta Fish",
                Type = "Fish",
                DiveSpeed = 1,
                SwimSpeed = 2
            };
            CopperHeadSnakes copperHead = new CopperHeadSnakes()
            {
                Name = "Copper Head",
                Type = "Snake",
                DiveSpeed = 3,
                SwimSpeed = 5,
                WalkSpeed = 8,
                RunSpeed = 12
            };
            Earthworms earthWorm = new Earthworms()
            {
                Name = "Earth Worm",
                Type = "Worm",
                DigSpeed = 2,
                WalkSpeed = 1,
                RunSpeed = 2
            };
            Finches finch = new Finches()
            {
                Name = "Finch",
                Type = "Bird",
                DiveSpeed = 5,
                SwimSpeed = 5,
                WalkSpeed = 1,
                RunSpeed = 2,
                FlyDiveSpeed = 50,
                FlightSpeed = 30
            };
            Gerbils gerbil = new Gerbils()
            {
                Name = "Gerbil",
                Type = "Rodentia",
                DiveSpeed = 1,
                SwimSpeed = 2,
                WalkSpeed = 4,
                RunSpeed = 8,
                DigSpeed = 3
            };
            Mice mouse = new Mice()
            {
                Name = "Mouse",
                Type = "Rodentia",
                DiveSpeed = 1,
                SwimSpeed = 2,
                WalkSpeed = 4,
                RunSpeed = 8,
                DigSpeed = 3
            };
            Parakeets parakeet = new Parakeets()
            {
                Name = "ParaKeet",
                Type = "Bird",
                DiveSpeed = 5,
                SwimSpeed = 5,
                WalkSpeed = 1,
                RunSpeed = 2,
                FlyDiveSpeed = 50,
                FlightSpeed = 30
            };
            Terrapins terrapin = new Terrapins()
            {
                Name = "Terrapin",
                Type = "Turtle",
                DiveSpeed = 1,
                SwimSpeed = 3,
                WalkSpeed = 2,
                RunSpeed = 3
            };
            TimberRattlesnakes timberRattleSnake = new TimberRattlesnakes()
            {
                Name = "Timber Rattle Snake",
                Type = "Snake",
                DiveSpeed = 3,
                SwimSpeed = 5,
                WalkSpeed = 8,
                RunSpeed = 12
            };

            Animals animalLists = new Animals()
            {
                AboveGroundAnimals = new List<IAboveGround>()
                {
                    ant, copperHead, earthWorm, finch, gerbil, mouse, parakeet, terrapin, timberRattleSnake 
                },
                FlyAboveGroundAnimals = new List<IFlyAboveGround>()
                {
                    finch, parakeet
                },
                UnderGroundAnimals = new List<IUnderGround>()
                {
                    ant, earthWorm, gerbil, mouse
                },
                UnderWaterAnimals = new List<IUnderWater>()
                {
                    bettaFish, copperHead, finch, gerbil, mouse, parakeet, terrapin, timberRattleSnake
                }
            };

            // Console.WriteLine("");
            // Console.WriteLine("Here is a list of animals that walk on land:");

            // foreach(IAboveGround animal in animalLists.AboveGroundAnimals)
            // {
            //     Console.WriteLine(animal);
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Here is a list of animals that fly above the ground:");

            // foreach(IFlyAboveGround animal in animalLists.FlyAboveGroundAnimals)
            // {
            //     Console.WriteLine(animal);
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Here is a list of animals that dig under ground:");

            // foreach(IUnderGround animal in animalLists.UnderGroundAnimals)
            // {
            //     Console.WriteLine(animal);
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Here is a list of animals that swim under water:");

            // foreach(IUnderWater animal in animalLists.UnderWaterAnimals)
            // {
            //     Console.WriteLine(animal);
            // }
            
            Console.WriteLine("");
            ant.Dig();
            gerbil.Walk();
            mouse.Run();
            earthWorm.Dig();
            bettaFish.Swim();
            copperHead.Dive();
            finch.TakeOff();
            parakeet.Land();
            terrapin.Swim();
            timberRattleSnake.Surface();
        }
    }
}
