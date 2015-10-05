using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Site.Models
{
    public class EventListing : BasePage
    {
        public EventListing(IPublishedContent content) : base(content)
        {
        }

        public string PageHeading { get; set; }

        public List<EventPage> UpcomingEvents { get; set; }

        public List<EventPage> PastEvents { get; set; }
    }
}