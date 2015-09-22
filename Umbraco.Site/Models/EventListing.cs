using System;
using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models;
using Web.Ditto.Models;

namespace Umbraco.Site.Models
{
    public class EventListing : BasePage
    {
        public EventListing(IPublishedContent content) : base(content)
        {
        }

        public string PageTitle { get; set; }
    }
}