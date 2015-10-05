using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Umbraco.Core.Models;

namespace Umbraco.Site.Models
{
    public class EventPage : BasePage
    {
        public EventPage(IPublishedContent content) : base(content)
        {
        }

        public string Title { get; set; }

        // by default, EventDate will render with DateTimeBoth display template (if it exists)
        [UIHint("DateTimeBoth")]
        public DateTime EventDate { get; set; }

        public bool MembersOnly { get; set; }

        public decimal CostPrice { get; set; }

        public int MaximumAttendees { get; set; }

        //  by default, Introduction will render with MultilineText display template (if it exists)
        [DataType(DataType.MultilineText)] 
        public string Introduction { get; set; }

        public Image Image { get; set; }

        public DateTime ApplicationsOpen { get; set; }

        public DateTime ApplicationsClose { get; set; }

        public IHtmlString BodyText { get; set; }
    }
}