using System;
using System.Web;
using Umbraco.Core.Models;
using Web.Ditto.Models;

namespace Umbraco.Site.Models
{
    public class HomePage : BasePage
    {
        public HomePage(IPublishedContent content) : base(content)
        {
        }

        public string PageTitle { get; set; }

        public IHtmlString BodyText { get; set; }

        public int? EventsToShow { get; set; }
    }
}