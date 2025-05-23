using System.ComponentModel.DataAnnotations;

namespace DotNetBookstore.Models
{
    public class Category
    {
        //[Range (100, 500)]
        public int CategoryId { get; set; }
        [Display (Name = "Category Name", Prompt ="Enter a category name")]
        [Required(ErrorMessage = "Please enter a category name")]
        public string Name { get; set; }

    }
}
