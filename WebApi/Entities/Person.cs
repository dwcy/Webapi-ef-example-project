using System.ComponentModel.DataAnnotations;

namespace ITHS.Webapi.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(30), Required]
        public string FirstName { get; set; }

        [MaxLength(30), Required]
        public string LastName { get; set; }


        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    
    }
}
