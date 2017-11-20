using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Kalitte.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Haber Başlığı")]
        public string Header { get; set; }

        [Required]
        [AllowHtml]
        [StringLength(300, MinimumLength = 10)]
        [Display(Name = "Haber İçeriği")]
        public string Body { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Haber Tipi")]
        public IEnumerable<SelectListItem> NewsTypes { get; set; }

        [Required]
        [Display(Name = "Haber Tipi")]
        public string SelectedNewsCategory { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Oluşturan ID")]
        public string ApplicationUserId { get; set; }

    }
}