﻿using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.ViewComponents.MemberLayout
{
    public class _MemberLayoutSidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
