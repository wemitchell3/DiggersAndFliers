namespace DiggersAndFliers {
    public interface IFlyAboveGround
    {
        int FlightSpeed { get; set; }
        int FlyDiveSpeed { get; set; }
        void TakeOff();
        void Land();
    }
}