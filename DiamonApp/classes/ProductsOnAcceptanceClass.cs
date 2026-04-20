
namespace DiamondApp.classes
{
    public class ProductsOnAcceptanceClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Count { get; set; }
        public decimal Price { get; set; }
        public string ProviderName { get; set; }
        public string LoginEmployee {  get; set; }

        public ProductsOnAcceptanceClass(string name, double count, decimal price, string providerName, string loginEmployee)
        {
            Id = Guid.NewGuid();
            Name = name;
            Count = count;
            Price = price;
            ProviderName = providerName;
            LoginEmployee = loginEmployee;
        }

        public ProductsOnAcceptanceClass() {}
    }
}
