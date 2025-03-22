using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vols.Models
{
    public class Category
    {

        public int Id { get; set; }
            
        [DisplayName("Name of Category")]
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
    }
}
