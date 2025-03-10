namespace ImageProcessingBackend.Models
{
    public class ImageMetadata
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string FilePath { get; set; }
        public DateTime Timestamp { get; set; }
        public string CameraParameters { get; set; }
    }
}
