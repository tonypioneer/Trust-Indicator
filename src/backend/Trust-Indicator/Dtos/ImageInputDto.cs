using System.ComponentModel.DataAnnotations;
namespace Trust_Indicator.Dtos
{
    public class ImageInputDto
    {
        [Required]
        public int UserID { get; set; }
        public string ImageTitle { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string? ImageDescription { get; set; }
        [Timestamp]
        public DateTime UploadDate { get; set; }
        public string Tag { get; set; }
    }
}
