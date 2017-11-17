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
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Haber Başlığı")]
        public string Header { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 10)]
        [Display(Name = "Haber İçeriği")]
        public string Body { get; set; }

        public string CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public string CreationDate { get; set; }

        [Display(Name = "Haber Tipi")]
        public IEnumerable<SelectListItem> NewsTypes { get; set; }

        [Required]
        public string SelectedNewsCategory { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}