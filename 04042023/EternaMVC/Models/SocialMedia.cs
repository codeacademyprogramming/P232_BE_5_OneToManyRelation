using System.ComponentModel.DataAnnotations;

namespace EternaMVC.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Url { get; set; }
        [Required]
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
