using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Our.Umbraco.Ditto;
using Umbraco.Site.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Site.Controllers
{
    public class EventListingController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            // use Ditto to get strongly typed model
            var poco = model.Content.As<EventListing>();

            // get all visible events and project to our strongly typed model
            var allEvents = model.Content.Children.Where(x => x.IsVisible()).Select(x => x.As<EventPage>()).ToList();

            // list upcoming events in ascending date order
            poco.UpcomingEvents = allEvents
                .Where(x => x.EventDate >= DateTime.Today)
                .OrderBy(x => x.EventDate)
                .ToList();

            // list past events in descending date order
            poco.PastEvents = allEvents
                .Where(x => x.EventDate < DateTime.Today)
                .OrderByDescending(x => x.EventDate)
                .ToList();

            // pass model to template/view
            return base.Index(new RenderModel(poco));
        }
    }
}
