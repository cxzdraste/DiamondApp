using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonApp.Classes
{
    public class ShippingBasketClass
    {
        public Guid Id { get; set; }        
        public List<ProductClass> ListOfProducts { get; set; }
        public double PurchasePrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPlace { get; set; }
        public string LoginStorekeeper { get; set; }
    }
}
