using System;

namespace Traversal.EntityLayer.Concrate
{
    public class ContactUs
    {
        public int ContactUsID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public string MessageType { get; set; }
        public bool Status { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
