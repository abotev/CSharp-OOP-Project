namespace Shop.Data.Interfaces
{
    public interface IStateable
    {
        bool State { get; set; }

        void TurnOn();

        void TurnOff();

    }
}
