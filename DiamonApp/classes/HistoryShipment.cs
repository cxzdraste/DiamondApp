using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonApp.Classes
{
    public class HistoryShipment
    {
        public Guid Id { get; set; }
        public List<ShippingBasketClass> Shipments { get; set; }
    }
}
