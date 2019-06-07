using System;
using System.Collections.Generic;

namespace DiggersAndFliers 
{
    public class Animals
    {
        public List<IAboveGround> AboveGroundAnimals { get; set; }
        public List<IFlyAboveGround> FlyAboveGroundAnimals { get; set; }
        public List<IUnderGround> UnderGroundAnimals { get; set; }
        public List<IUnderWater> UnderWaterAnimals { get; set; } 
    }
}