using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concrate
{
    public class Newsletter
    {
        [Key]
        public int NewsletterID { get; set; }

        public string Mail { get; set; }
    }
}
