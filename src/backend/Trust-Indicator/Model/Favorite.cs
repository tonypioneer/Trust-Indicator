using System.ComponentModel.DataAnnotations;

namespace TrustIndicator.Model
{
    public class Favorite
    {
        [Key]
        public int RecordID { get; set; }
        [Required]
        public int PhotoID { get; set; }
        [Required]
        public int UserID { get; set; }

        public bool Is_Favorite { get; set; }
        public string Comment { get; set; }
        [Timestamp]
        public byte[] Create_Date { get; set; }
    }
}