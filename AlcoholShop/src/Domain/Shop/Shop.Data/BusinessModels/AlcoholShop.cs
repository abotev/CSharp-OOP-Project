using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {

        public string Name { get; set; }

        public List<Table> Tables { get; set; }

        public List<Person> Waitresses { get; set; }

        public Fridge Fridge { get; set; }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Alcohol))
            {
                return false;
            }
            return true;
        }
    }
}
