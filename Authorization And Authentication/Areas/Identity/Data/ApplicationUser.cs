using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Authorization_And_Authentication.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser

    {
        [MaxLength(255)]
        public string firstName { set; get; }
        [MaxLength (255)]
        public string lastName { set; get; }
    }
}
