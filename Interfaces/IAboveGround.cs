namespace DiggersAndFliers {
    public interface IAboveGround
    {   
        int RunSpeed { get; set; }
        int WalkSpeed { get; set; }
        void Run();
        void Walk();
    }
}