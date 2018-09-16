using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class CandyShop : BaseShop
    {
        public List<Person> Children { get; set; }

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
