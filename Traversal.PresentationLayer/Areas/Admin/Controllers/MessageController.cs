using Microsoft.AspNetCore.Mvc;
using System;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrate;
using Traversal.PresentationLayer.Models;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public MessageController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.TGetReceivedMessages();
            return View(values);
        }
        public IActionResult SentMessages()
        {
            var values = _contactUsService.TGetSentMessages();
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = _contactUsService.TGetById(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult Reply(int id)
        {
            var value = _contactUsService.TGetById(id);
            ViewBag.Name = value.Name;
            ViewBag.Subject = value.Subject;
            ViewBag.Mail = value.Mail;
            return View();
        }

        [HttpPost]
        public IActionResult Reply(MailRequest mailRequest)
        {
            MailRequest message=new MailRequest() 
            { 
            Body = mailRequest.Body,
            Subject = mailRequest.Subject,
            Name="Admin",
            ReceiverMail = mailRequest.ReceiverMail,
            };
            ContactUs contact = new ContactUs()
            {
                Mail= mailRequest.ReceiverMail,
                MessageBody = mailRequest.Body,
                MessageDate=DateTime.Now,
                Name=mailRequest.Name,
                Status=true,
                MessageType="Gönderilen Mesajlar",
                Subject=mailRequest.Subject,
            };
            _contactUsService.TAdd(contact);
            SendMails sendMails = new SendMails();
            sendMails.SendMail(message);
            return RedirectToAction("SentMessages");
        }

        public IActionResult DeleteMessage(int id)
        {
            _contactUsService.TContactUsStatusChangeToFalse(id);
            return RedirectToAction("Index");
        }

        public IActionResult RestoreMessage(int id)
        {
            _contactUsService.TContactUsStatusChangeToTrue(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeletedMessages()
        {
            var values=_contactUsService.TGetDeletedMessages();
            return View(values);
        }
    }
}
