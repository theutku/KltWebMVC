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
        public string Header { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 10)]
        public string Body { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [Required]
        public string SelectedNewsCategory { get; set; }

        [Required]
        public string ImageData { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

    }

    public class CreateNewsViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Haber Başlığı")]
        public string Header { get; set; }

        [Required]
        [AllowHtml]
        [StringLength(300, MinimumLength = 10)]
        [Display(Name = "Haber İçeriği")]
        public string Body { get; set; }

        [Required]
        [Display(Name = "Haber Tipi")]
        public string SelectedNewsCategory { get; set; }
        public IEnumerable<SelectListItem> NewsTypes { get; internal set; }

    }


    public class NewsListingViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Haber Tipi")]
        public string SelectedNewsCategory { get; set; }

        [Display(Name = "Haber İçeriği")]
        public string Body { get; set; }

        [Display(Name = "Haber Başlığı")]
        public string Header { get; set; }

        [Display(Name = "Oluşturan")]
        public string UserName { get; set; }

        [Display(Name = "İçerik Fotoğrafı")]
        public string ImagePath { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreateDate { get; set; }
    }

    public interface IHeaderedPageModel
    {
        string HeaderPageText { get; }
        bool Rendered { get; }
        string HeaderFontSize { get; set; }
    }

    public class ImportantHeaderPageModel<TModel> : HeaderedPageModel<TModel>
    {
        public ImportantHeaderPageModel(string headerText, TModel pageModel) : base(headerText,pageModel)
        {
            //this.HeaderFontSize = "20px";
        }

    }

    public class HeaderedPageModel<TModel> : IHeaderedPageModel
    {
        public HeaderedPageModel()
        {

        }
        public HeaderedPageModel(string headerText,TModel pageModel)
        {
            this.HeaderPageText = headerText;
            this.PageModel = pageModel;
            //this.HeaderFontSize = "12px";
        }

        public string HeaderFontSize { get; set; }

        public string HeaderPageText
        {
            get; set;
        }

        public bool Rendered { get; set; } = true;
        public TModel PageModel { get; set; }
    }


    public class SimpleHeader : IHeaderedPageModel
    {
        public SimpleHeader(string text)
        {
            this.HeaderPageText = text;
            this.HeaderFontSize = "16px";
        }

        public string HeaderFontSize
        {
            get; set;
        }

        public string HeaderPageText
        {
            get; set;
        }

        public bool Rendered
        {
            get
            {
                return true;
            }
        }
    }
}