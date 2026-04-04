using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamonApp.Classes
{
    public class CategoryClass
    {
        public Guid Id { get; set; }
        public List<string> NamesOfCategory { get; set; }
        
        public CategoryClass( List<string> namesOfCategory)
        {
            Id = new Guid();    
            NamesOfCategory = namesOfCategory;
        }
        public CategoryClass(string namesOfCategory)
        {
            NamesOfCategory.Add(namesOfCategory);
        }
    }
}
