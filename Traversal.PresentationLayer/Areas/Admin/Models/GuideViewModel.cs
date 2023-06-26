using Microsoft.AspNetCore.Http;

namespace Traversal.PresentationLayer.Areas.Admin.Models
{
    public class GuideViewModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string TwitterUrl { get; set; }

        public string InstagramUrl { get; set; }

        public string Description { get; set; }
        public IFormFile Image { get; set; }

        
    }
}
