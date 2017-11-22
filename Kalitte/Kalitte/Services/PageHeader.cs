using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalitte.Services
{
    public interface IHeaderedPageModel
    {
        string HeaderText { get; }
        bool IsRendered { get; }
        string HeaderFontSize { get; set; }
    }

    public class HeaderedPageModel<TModel> : IHeaderedPageModel
    {
        public HeaderedPageModel()
        {

        }

        public HeaderedPageModel(string headerText, TModel pageModel)
        {
            this.HeaderText = headerText.ToUpper();
            this.PageModel = pageModel;
        }

        public TModel PageModel { get; set; }

        public string HeaderText { get; set; }
        public bool IsRendered { get; set; } = true;
        public string HeaderFontSize { get; set; }
    }

    public class SimplePageHeader : IHeaderedPageModel
    {
        public SimplePageHeader(string text)
        {
            this.HeaderText = text;
            this.HeaderFontSize = "24px";
        }

        public string HeaderText { get; set; }
        public bool IsRendered
        {
            get
            {
                return true;
            }
        }
        public string HeaderFontSize { get; set; }

    }
}