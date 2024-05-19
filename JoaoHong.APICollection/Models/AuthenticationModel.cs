using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace JoaoHong.APICollection.Models
{
    public class AuthenticationModel
    {
        [SwaggerSchema(ReadOnly = true)]
        public long AuthenticationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
