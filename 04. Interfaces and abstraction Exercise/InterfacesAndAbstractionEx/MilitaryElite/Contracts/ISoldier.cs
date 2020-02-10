namespace MilitaryElite.Contracts
{
    public interface ISoldier : IPrivate
    {
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
