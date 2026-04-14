using DiamonApp.classes;
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
        public string ProductsName { get; set; }
        public string UniteOfMeasure { get; set; }
        public DateTime DateShipment { get; set; }
        public int Count { get; set; }
        public decimal SumShipment { get; set; }
        public decimal Profit { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPlace { get; set; }
        public string LoginStorekeeper { get; set; }
        
        public HistoryShipment(string productsName, string uniteOfMeasure,DateTime dateShipment, int count, decimal sumShipment, decimal profit, string customerName, string customerPlace, string loginStorekeeper)
        {
            ProductsName = productsName;
            UniteOfMeasure = uniteOfMeasure;
            DateShipment = dateShipment;
            Count = count;
            SumShipment = sumShipment;
            Profit = profit;
            CustomerName = customerName;
            CustomerPlace = customerPlace;
            LoginStorekeeper = loginStorekeeper;
        }
    }
}
