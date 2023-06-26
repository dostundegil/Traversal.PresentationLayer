using Microsoft.AspNetCore.Http;

namespace Traversal.PresentationLayer.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
        public string Phone{ get; set; }
        public string Mail{ get; set; }
        public IFormFile Image{ get; set; }
    }
}
