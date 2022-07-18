using System.ComponentModel.DataAnnotations;

namespace ProductMVCScaffold.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required./ Името е задолжително")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters./ Името треба да биде помеѓу 2 и 50 букви.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required./ Цената е задолжителна")]
        [Range(0.001, double.MaxValue, ErrorMessage = "Price must be atleast 0.001 denars./ Цената мора да e минимум 0.001 денари.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Expiration date is required./ Рокот е задолжителен")]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }
    }
}
