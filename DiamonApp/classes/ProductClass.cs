using DiamonApp.classes;
using System;

namespace DiamonApp.Classes
{
    public class ProductClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UniteOfMeasure { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Category { get; set; }
        public double Rest { get; set; }
        public string Creator { get; set; }
        public DateTime EndDateOfTheDay { get; set; }
        public int UntilTheEndOfTheSeason { get; set; }
        public double Discount { get; set; }
        public decimal FinalyPrice { get; set; }
        public ProductClass(string name, string uniteOfMeasure, decimal purchasePrice, string category, double rest, string creator, DateTime endDateOfTheDay, int untilTheEndOfTheSeason, double discount) 
        {
            Id = Guid.NewGuid();
            Name = name;
            UniteOfMeasure = uniteOfMeasure;
            PurchasePrice = purchasePrice;
            Category = category;
            Rest = rest;
            Creator = creator;
            EndDateOfTheDay = endDateOfTheDay;
            UntilTheEndOfTheSeason = untilTheEndOfTheSeason;
            Discount = discount;
            FinalyPrice = PurchasePrice - PurchasePrice * ((decimal)discount/100);
        }
    }
}
