using System.ComponentModel.DataAnnotations;

namespace SignInPage.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public long mobile { get; set; }
        public string address { get; set; }
    }
}
