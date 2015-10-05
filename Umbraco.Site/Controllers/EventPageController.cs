using System.Web.Mvc;
using Our.Umbraco.Ditto;
using Umbraco.Site.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Site.Controllers
{
    public class EventPageController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            // use Ditto to get strongly typed model
            model = new RenderModel(model.Content.As<EventPage>());

            // pass model to template/view
            return base.Index(model);
        }
    }
}
