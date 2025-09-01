using System.ComponentModel.DataAnnotations.Schema;
namespace CrudHoor.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string? ImagePath { get; set; }
    }
}
