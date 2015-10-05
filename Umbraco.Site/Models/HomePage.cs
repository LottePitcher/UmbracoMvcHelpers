using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models;

namespace Umbraco.Site.Models
{
    public class HomePage : BasePage
    {
        public HomePage(IPublishedContent content) : base(content)
        {
        }

        public string PageHeading { get; set; }

        public IHtmlString BodyText { get; set; }

        public int? EventsToShow { get; set; }

        public List<EventPage> UpcomingEvents { get; set; }
    }
}