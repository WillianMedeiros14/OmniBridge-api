using System.ComponentModel.DataAnnotations;
using omniBridge_service.Models;

namespace omniBridge_service.Models
{
    public class AddressModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public string Street { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Number { get; set; }

        public string UserId { get; set; }
        public virtual UserModel User { get; set; }
    }
}