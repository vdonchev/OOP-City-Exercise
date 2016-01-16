namespace City.Contracts
{
    public interface ICommand
    {
        void Execute(params string[] args);
    }
}