using BaseAPI.Domain.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BaseAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
        public IList<Siparis> Siparisler { get; set; }
    }
}