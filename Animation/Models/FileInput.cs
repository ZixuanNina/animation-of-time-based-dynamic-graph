using Microsoft.AspNetCore.Http;

namespace Animation.Models
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}