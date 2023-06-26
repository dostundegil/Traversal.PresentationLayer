using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concrate
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image{ get; set; }

        public bool IsBigImage { get; set; }

        public bool Status { get; set; }
    }
}
