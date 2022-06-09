using System.ComponentModel.DataAnnotations;

namespace BaseAPI.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}