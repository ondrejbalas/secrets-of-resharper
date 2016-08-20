namespace ResharperTalk.Abstractions
{
    public interface IVehicle
    {
        void Alert();
        void SetSpeed(int speed);
        void Stop();
        int CurrentSpeed { get; }
    }
}