using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    [MetadataType(typeof(memberMetaData))]
    public partial class member
    {
        public class memberMetaData
        {
            [DisplayName("Member Name")]
            public string name { get; set; }

            [DisplayName("Member Address")]
            public string address { get; set; }

            [DisplayName("Member Phone no")]
            public Nullable<int> phone { get; set; }
        }
    }
}