using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class FileUpload
    {
        [StringLength(60, MinimumLength = 3), Display(Name = "Title"), Required]
        public string Title { get; set; }

        [Display(Name = "Public Schedule"), Required]
        public IFormFile UploadPublicSchedule { get; set; }

        [Display(Name = "Private Schedule"), Required]
        public IFormFile UploadPrivateSchedule { get; set; }
    }
}
