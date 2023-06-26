using MimeKit;
using MailKit.Net.Smtp;
using TraversalCoreProje.Models;

namespace Traversal.PresentationLayer.Models
{
    public class SendMails
    {
        public void SendMail(MailRequest mailRequestViewModel)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "bulutbilisimmail@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequestViewModel.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequestViewModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequestViewModel.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("bulutbilisimmail@gmail.com", "jxaibxfcrvqiscge");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}
