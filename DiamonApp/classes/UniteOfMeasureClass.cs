namespace DiamonApp.classes
{
    public class UniteOfMeasureClass
    {
        public int Id { get; set;}
        public List<string> UnitesOfMeasure { get; set;}

        public UniteOfMeasureClass(int id,List<string> unitesOfMeasure)
        {
            Id = id;
            UnitesOfMeasure = unitesOfMeasure;
        }
        public UniteOfMeasureClass(string uniteOfMeasure) 
        {
            UnitesOfMeasure.Add(uniteOfMeasure);
        }
    }
}
