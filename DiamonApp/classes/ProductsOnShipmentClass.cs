using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonApp.Classes
{
    public class ProductsOnShipmentClass
    {
        public Guid Id { get; set; }        
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPlace { get; set; }
        public string LoginStorekeeper { get; set; }

        public ProductsOnShipmentClass(string name, int count, decimal sum, string customerName, string customerPlace, string loginStorekeeper)
        {
            Id = Guid.NewGuid();
            Name = name;
            Count = count;
            Sum = sum;
            CustomerName = customerName;
            CustomerPlace = customerPlace;
            LoginStorekeeper = loginStorekeeper;
        }
    }
}
