using System;
using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models;
using Web.Ditto.Models;

namespace Umbraco.Site.Models
{
    public class EventPage : BasePage
    {
        public EventPage(IPublishedContent content) : base(content)
        {
        }

        public string Title { get; set; }

        public DateTime? EventDate { get; set; }
        public DateTime? ApplicationsOpen { get; set; }
        public DateTime? ApplicationsClose { get; set; }

        public bool MembersOnly { get; set; }
        public string Introduction { get; set; }

        public IHtmlString BodyText { get; set; }
        public Image Image { get; set; }

        public List<EventPage> SimilarEvents { get; set; }
        public int? MaximumAttendees { get; set; }
        public decimal? CostPrice { get; set; }
    }
}