using Shop.Data.BusinessModels;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            var alcoholShop = new AlcoholShop();
            alcoholShop.Company.Name = "Alcohol Shop OOD";
            alcoholShop.Address = new Address("Sofia", "Cherni vrah", "20");
            alcoholShop.Name = "The Awesome Alcohol Shop";
            alcoholShop.Fridge = new Fridge();
            alcoholShop.Fridge.TurnOn();
            var sellerAlcohol = new Seller("Pesho", "Ivanov", 25);
            alcoholShop.Seller = sellerAlcohol;
            var waitress = new Waitress("Maria", "Marinova", 31);
            alcoholShop.Waitresses.Add(waitress);
            var client = new Client("Ivan", "Ivanov", 28);
            alcoholShop.Clients.Add(client);

            var candyShop = new CandyShop();
            candyShop.Company.Name = "Candy Shop OOD";
            candyShop.Address = new Address("Sofia", "Dondukov", "48");
            candyShop.Name = "The Awesome Candy shop";
            candyShop.AirConditioner = new AirConditioner();
            candyShop.AirConditioner.TurnOn();
            var sellerCandy = new Seller("Grigor", "Iliev", 25);
            candyShop.Seller = sellerCandy;
            var candySpecialist = new CandySpecialist("Gosho", "Dimitrov", 19);
            candyShop.CandySpecialists.Add(candySpecialist);
            var anotherClient = new Client("Vasil", "Vasilev", 35);
            candyShop.Clients.Add(anotherClient);

            var johnnieWalker = new Alcohol("Johnnie Walker",150);
            var jackDaniels = new Alcohol("Jack Daniel's", 120);
            alcoholShop.AddGood(johnnieWalker);
            alcoholShop.AddGood(jackDaniels);

            var snickers = new Candy("Snickers", 22);
            var twix = new Candy("Twix", 48);
            var mars = new Candy("Mars", 28);
            candyShop.AddGood(snickers);
            candyShop.AddGood(twix);
            candyShop.AddGood(mars);

            Console.WriteLine($"Income AlcoholShop before ---> {alcoholShop.Income} " +
                $"Item count: {alcoholShop.Goods.Count()}");
            alcoholShop.Sell(jackDaniels);
            Console.WriteLine($"Income Alcoholshop after ---> {alcoholShop.Income} " +
                $"Item count: {alcoholShop.Goods.Count()}");

            Console.WriteLine();

            Console.WriteLine($"Income CandyShop before ---> {candyShop.Income} " +
                $"Item count: {candyShop.Goods.Count()}");
            candyShop.Sell(snickers);
            Console.WriteLine($"Income Candyshop after ---> {candyShop.Income} " +
                $"Item count: {candyShop.Goods.Count()}");

            Console.ReadLine();
        }
    }
}
