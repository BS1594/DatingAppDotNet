

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using SQLitePCL;

namespace API.Model
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}