using System;
using System.Linq;
using System.Web.Mvc;
using Our.Umbraco.Ditto;
using Umbraco.Site.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Site.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            // use Ditto to get strongly typed model
            var poco = model.Content.As<HomePage>();

            // get X upcoming events, order by date ascending, and project as strongly typed models
            poco.UpcomingEvents = model.Content.Descendants("EventPage")
                .Where(x => x.IsVisible() && x.GetPropertyValue<DateTime>("eventDate") >= DateTime.Today)
                .OrderBy(x => x.GetPropertyValue<DateTime>("eventDate"))
                .Take(poco.EventsToShow.GetValueOrDefault())
                .Select(x => x.As<EventPage>())
                .ToList();

            // pass model to template/view
            return base.Index(new RenderModel(poco));
        }
    }
}
