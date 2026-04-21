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

        public ProductClass(string name, string uniteOfMeasure, decimal price, string category, double rest, string creator) 
        {
            Id = Guid.NewGuid();
            Name = name;
            UniteOfMeasure = uniteOfMeasure;
            PurchasePrice = price;
            Category = category;
            Rest = rest;
            Creator = creator;
        }
    }
}
