using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
   public class Appliance
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
