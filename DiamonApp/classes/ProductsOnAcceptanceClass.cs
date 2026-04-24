namespace DiamondApp.classes
{
    /// <summary>
    /// Представляет товары, принятые на склад
    /// </summary>
    public class ProductsOnAcceptanceClass
    {
        /// <summary>
        /// Уникальный идентификатор записи о приёмке
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество принятого товара
        /// </summary>
        public double Count { get; set; }

        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Наименование поставщика
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Логин сотрудника, принявшего товар
        /// </summary>
        public string LoginEmployee { get; set; }

        /// <summary>
        /// Инициализирует новую запись о приёмке товара
        /// </summary>
        public ProductsOnAcceptanceClass(string name, double count, decimal price, string providerName, string loginEmployee)
        {
            Id = Guid.NewGuid();
            Name = name;
            Count = count;
            Price = price;
            ProviderName = providerName;
            LoginEmployee = loginEmployee;
        }

        /// <summary>
        /// Инициализирует пустую запись о приёмке
        /// </summary>
        public ProductsOnAcceptanceClass() { }
    }
}