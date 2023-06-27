using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Concrate;

namespace Traversal.PresentationLayer.ViewComponents.Comment
{
    public class _CommentListPartial:ViewComponent
    {
        private readonly ICommentService _commentService;
        Context context = new Context();
        public _CommentListPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.v= context.Comments.Where(x=>x.DestinationID==id).Count();
            var values = _commentService.TGetCommentsWithDestinationandUser(id);
            return View(values);
        }
    }
}
