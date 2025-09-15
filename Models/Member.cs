using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCAuthorization.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("帳號")]
        public string UserId { get; set; }

        [Required]
        [DisplayName("密碼")]
        public string Password { get; set; }

        [Required]
        [DisplayName("姓名")]
        public string Name { get; set; }

        [Required]
        [DisplayName("電子信箱")]
        public string Email { get; set; }

    }
}
