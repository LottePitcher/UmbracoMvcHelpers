using System.Web.Mvc;
using Our.Umbraco.Ditto;
using Umbraco.Site.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Umbraco.Site.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }
    }
}
