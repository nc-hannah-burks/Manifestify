
using System.ComponentModel.DataAnnotations;

namespace ManifestationApi.DTOs
{
    public class UserDto
    {
        public required string Id { get; set; }
        public required string Forename { get; set; }
        public required string Surname { get; set; }
        public required string MemorableQuestion { get; set; }
        public required string MemorableAnswer { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
