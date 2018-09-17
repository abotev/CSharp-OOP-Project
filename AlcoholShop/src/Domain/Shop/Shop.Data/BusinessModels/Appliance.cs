using Shop.Data.Interfaces;

namespace Shop.Data.BusinessModels
{
    public class Appliance : IStateable
    {
        public bool State { get; set; }

        public void TurnOn()
        {
            this.State = true;
        }
        public void TurnOff()
        {
            this.State = false;
        }
    }
}
