using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class CandyShop : BaseShop
    {
        public CandyShop()
        {
            this.CandySpecialists = new List<Person>();
        }

        public List<Person> CandySpecialists { get; set; }

        public AirConditioner AirConditioner { get; set; }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Candy))
            {
                return false;
            }
            return true;
        }
    }
}
