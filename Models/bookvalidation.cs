using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    [MetadataType(typeof(bookMetaData))]
    public partial class book
    {
        public class bookMetaData
        {
            [DisplayName("Book Name")]
            public string bname { get; set; }

            [DisplayName("Book Category")]
            public Nullable<int> cat_id { get; set; }

            [DisplayName("Author Name")]
            public Nullable<int> a_id { get; set; }

            [DisplayName("Publisher Name")]
            public Nullable<int> p_id { get; set; }

            [DisplayName("Content")]
            public string contents { get; set; }

            [DisplayName("Pages")]
            public Nullable<int> pages { get; set; }

            [DisplayName("Edition")]
            public string edition { get; set; }
        }
    }
}