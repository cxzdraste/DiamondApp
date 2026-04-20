using System.Diagnostics;
using DiamonApp.classes;
using DiamonApp.Classes;
using DiamondApp.classes;
using DiamondApp.Hash;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DiamonApp.DataBase
{
    public class AllDB : DbContext
    {
        public DbSet<ProductClass> Products {  get; set; }
        public DbSet<CategoryClass> Categories { get; set; }
        public DbSet<EmployeeClass> Employess { get; set; }
        public DbSet<HistoryShipment> HistoryShipment { get; set; }
        public DbSet<ProductsOnShipmentClass> ProductsOnShipments { get; set; }
        public DbSet<ProductsOnAcceptanceClass> ProductsOnAcceptance { get; set; }
        public DbSet<UniteOfMeasureClass> UniteOfMeasures { get; set; }

        public AllDB()
        {
            Database.EnsureCreated();
            EnsureExist();
            AddUnitesOfMeasure();
            AddDataCategories();
            AddDataProducts();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=allDataBase.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product base
            modelBuilder.Entity<ProductClass>().ToTable("Products");
            modelBuilder.Entity<ProductClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.UniteOfMeasure);
                entity.Property(p => p.Category);
                entity.Property(p => p.Price);
                entity.Property(p => p.Rest);
                entity.Property(p => p.Creator);
            });

            // UniteOfMeasure base
            modelBuilder.Entity<UniteOfMeasureClass>().ToTable("UniteOfMeasures");
            modelBuilder.Entity<UniteOfMeasureClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.UnitesOfMeasure);
            });

            // Categories base
            modelBuilder.Entity<CategoryClass>().ToTable("Categories");
            modelBuilder.Entity<CategoryClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.NamesOfCategory);
            });

            //Employees base
            modelBuilder.Entity<EmployeeClass>().ToTable("Employess");
            modelBuilder.Entity<EmployeeClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.Surname);
                entity.Property(p => p.Login);
                entity.Property(p => p.Password);
                entity.Property(p => p.Job);
            });

            //History shipment base
            modelBuilder.Entity<HistoryShipment>().ToTable("HistoryShipment");
            modelBuilder.Entity<HistoryShipment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.ProductsName);
                entity.Property(p => p.UniteOfMeasure);
                entity.Property(p => p.DateShipment);
                entity.Property(p => p.Count);
                entity.Property(p => p.SumShipment);
                entity.Property(p => p.Profit);
                entity.Property(p => p.CustomerName);
                entity.Property(p => p.CustomerPlace);
                entity.Property(p => p.LoginStorekeeper);
            });

            //Products on shipment base
            modelBuilder.Entity<ProductsOnShipmentClass>().ToTable("ProductsOnShipmentClass");
            modelBuilder.Entity<ProductsOnShipmentClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.Count);
                entity.Property(p => p.CustomerName);
                entity.Property(p => p.CustomerPlace);
                entity.Property(p => p.LoginStorekeeper);
            });

            //Products on acceptance base
            modelBuilder.Entity<ProductsOnAcceptanceClass>().ToTable("ProductsOnAcceptanceClass");
            modelBuilder.Entity<ProductsOnAcceptanceClass>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.Count);
                entity.Property(p => p.Price);
                entity.Property(p => p.ProviderName);
                entity.Property(p => p.LoginEmployee);
            });
        }
        private void EnsureExist()
        {
            if (!Employess.Any(w => w.Login == "777"))
            {
                Employess.Add(new EmployeeClass("Admin", "One", "777", SimpleHash.HashSHA256("777"), Enums.JobsEnumcs.Administrator));
            }
            if (!Employess.Any(w => w.Login == "12"))
            {
                Employess.Add(new EmployeeClass("Кладовщик", "Коробков", "12", SimpleHash.HashSHA256("12"), Enums.JobsEnumcs.Storekeeper));
            }
            SaveChanges();
            
        }

        private void AddDataCategories()
        {
                if (!Categories.Any())
                {
                    var newListOfCategories = new List<string>() { "Кольцо","Серьги","Колье","Браслет","Брошь"};
                    Categories.Add(new CategoryClass(1,newListOfCategories));
                }
                SaveChanges();
        }
        private void AddUnitesOfMeasure()
        {
            if (!UniteOfMeasures.Any())
            {
                var newListOfCategories = new List<string>() { "Штуки","Граммы"};
                UniteOfMeasures.Add(new UniteOfMeasureClass(1, newListOfCategories));
            }
            SaveChanges();
        }
        private void AddDataProducts()
        {
                if (!Products.Any())
                {
                    //достаёт список категорий из бд
                    var allNamesLinq = new List<string>();
                    foreach (var category in Categories)
                    {
                        allNamesLinq.AddRange(category.NamesOfCategory);
                    }
                    var allUnitsLinq = new List<string>();
                    foreach (var unite in UniteOfMeasures)
                    {
                        allUnitsLinq.AddRange(unite.UnitesOfMeasure);
                    }
                    Products.AddRange(new ProductClass[]
                            {
                                new ProductClass( "Какое то кольцо", allUnitsLinq[0], 45000m, allNamesLinq[0], 30, Employess.FirstOrDefault( p => p.Login=="777").Login),
                                new ProductClass( "Какие то серьги", allUnitsLinq[0], 45000m, allNamesLinq[1], 30,Employess.FirstOrDefault( p => p.Login=="777").Login),
                                new ProductClass( "Какое то колье", allUnitsLinq[0], 45000m, allNamesLinq[2], 30,Employess.FirstOrDefault(p => p.Login == "777").Login),
                                new ProductClass( "Какой то браслет", allUnitsLinq[0], 45000m, allNamesLinq[3], 30, Employess.FirstOrDefault(p => p.Login == "777").Login),
                                new ProductClass( "Какая то брошь", allUnitsLinq[0], 45000m, allNamesLinq[4], 30, Employess.FirstOrDefault(p => p.Login == "777").Login)
                            });
                            SaveChanges();
                }
            
        }
    }
}
