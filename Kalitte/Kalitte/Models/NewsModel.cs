using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Kalitte.Models
{
    public class NewsModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Haber Başlığı")]
        public string Header { get; set; }

        [Required]
        [Display(Name ="Haber İçeriği")]
        public string Body { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public IEnumerable<SelectListItem> Category { get; set; }


        public virtual ApplicationUser User { get; set; }
    }
}