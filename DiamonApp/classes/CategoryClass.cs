using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamonApp.Classes
{
    public class CategoryClass
    {
        public int Id { get; set; }
        public List<string> NamesOfCategory { get; set; }
        
        public CategoryClass(int id, List<string> namesOfCategory)
        {
            Id = id;    
            NamesOfCategory = namesOfCategory;
        }
        public CategoryClass(string namesOfCategory)
        {
            NamesOfCategory.Add(namesOfCategory);
        }
    }
}
