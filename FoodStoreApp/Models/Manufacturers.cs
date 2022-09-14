using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FoodStoreApp.Models
{
    public class Manufacturers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Country { get; set; }
    }
}