using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrate;

namespace Traversal.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            var value = await _userManager.FindByIdAsync((p.AppUserID).ToString());
            p.CommentUser = value.Name;
            _commentService.TAdd(p);

            return RedirectToAction("Index", "Destination");
        }
    }
}
