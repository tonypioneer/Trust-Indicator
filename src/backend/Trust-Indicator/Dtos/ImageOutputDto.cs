namespace Trust_Indicator.Dtos
{
    public class ImageOutputDto
    {
        public int ImageID { get; set; }
        public string UserID { get; set; }
        public string ImageTitle { get; set; }
        public string ImageUrl { get; set; }
        public string? ImageDescription { get; set; }
        public byte[] UploadDate { get; set; }
        public string Tag { get; set; }
    }
}
