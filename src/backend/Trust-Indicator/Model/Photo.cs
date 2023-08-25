using System.ComponentModel.DataAnnotations;

namespace TrustIndicator.Model
{
    public class Photo
    {
        [Key]
        public int PhotoID { get; set; }
        [Required]
        public int UserID { get; set; }
        public string PhotoName { get; set; }
        [Required]
        public string PhotoUrl { get; set;}
        public string? PhotoDescription { get; set;}
        [Timestamp]
        public byte[] UploadDate { get; set; }
        public string Tag { get; set; }
    }
}