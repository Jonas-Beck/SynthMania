using System.ComponentModel.DataAnnotations;

namespace SynthMania.Models
{
    public class Customer
    {
        public Customer()
        {
            PaymentCard = new PaymentCard();
            Address = new Address();
        }

        [Required(ErrorMessage = "Firstname is required", AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }
        
        [Required]
        public Address Address { get; set; }

        [Required]
        public PaymentCard PaymentCard { get; set; }
        


    }
}