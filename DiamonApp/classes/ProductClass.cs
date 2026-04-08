using System;

namespace DiamonApp.Classes
{
    public class ProductClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UniteOfMeasureEnum UniteOfMeasure { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double Rest { get; set; }
        public string Creator { get; set; }
        public ProductClass(string name, UniteOfMeasureEnum uniteOfMeasure, decimal price, string category, double rest, string creator) 
        {
            Id = Guid.NewGuid();
            Name = name;
            UniteOfMeasure = uniteOfMeasure;
            Price = price;
            Category = category;
            Rest = rest;
            Creator = creator;
        }
    }
}
