using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace ITHS.Webapi.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(15), Required]
        public string RoleName { get; set; }
    }
}
