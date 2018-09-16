namespace Shop.Data.BusinessModels
{
    public class Address
    {
        public Address(string city, string street, string streetNumber)
            {
            this.City = city;
            this.Street = street;
            this.StreetNumber = StreetNumber;
            }
        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }
    }
}
