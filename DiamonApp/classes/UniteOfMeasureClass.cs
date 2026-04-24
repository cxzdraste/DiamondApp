namespace DiamonApp.classes
{
    /// <summary>
    /// Представляет справочник единиц измерения
    /// </summary>
    public class UniteOfMeasureClass
    {
        /// <summary>
        /// Уникальный идентификатор записи
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Список единиц измерения
        /// </summary>
        public List<string> UnitesOfMeasure { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр с идентификатором и списком единиц измерения
        /// </summary>
        public UniteOfMeasureClass(int id, List<string> unitesOfMeasure)
        {
            Id = id;
            UnitesOfMeasure = unitesOfMeasure;
        }

        /// <summary>
        /// Инициализирует новый экземпляр и добавляет одну единицу измерения
        /// </summary>
        public UniteOfMeasureClass(string uniteOfMeasure)
        {
            UnitesOfMeasure.Add(uniteOfMeasure);
        }
    }
}