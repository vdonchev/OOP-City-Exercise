namespace City.Contracts
{
    public interface ICityBuilder
    {
        ICity City { get; }

        IWriter Writer { get; }

        bool IsRunning { get; set; }

        void Run();

        void Stop();
    }
}