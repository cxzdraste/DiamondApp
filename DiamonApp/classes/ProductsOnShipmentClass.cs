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
        public decimal PurchasePrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPlace { get; set; }
        public string LoginStorekeeper { get; set; }

        public ProductsOnShipmentClass(string name, decimal purchasePrice, string customerName, string customerPlace, string loginStorekeeper)
        {
            Id = Guid.NewGuid();
            Name = name;
            PurchasePrice = purchasePrice;  
            CustomerName = customerName;
            CustomerPlace = customerPlace;
            LoginStorekeeper = loginStorekeeper;
        }
    }
}
