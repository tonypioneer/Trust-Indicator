﻿using System.ComponentModel.DataAnnotations;

namespace TrustIndicator.Model
{
    public class Metadata
    {
        [Key]
        public int PhotoID { get; set; }
        public int File_Size { get; set; }
        public string File_Type { get; set; }
        public string MIME_Type { get; set; }
        [Timestamp]
        public byte[] Create_Date { get; set; }
        [Timestamp]
        public byte[] Modify_Date { get; set; }
        public string Color_Space { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Lens { get; set; }
        public float Focal_Length { get; set; }
        public float Aperture { get; set; }
        public float Explosure { get; set; }
        public int ISO { get; set; }
        public string Flash { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Software { get; set; }
    }
}