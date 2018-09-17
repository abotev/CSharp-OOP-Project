using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {
        public AlcoholShop()
        {
            this.Waitresses = new List<Person>();
            this.Tables = new List<Table>();

        }

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
