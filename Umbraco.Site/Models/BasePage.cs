using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace Umbraco.Site.Models
{
    public class BasePage : PublishedContentModel
    {
        public BasePage(IPublishedContent content) : base(content)
        {
        }

        public string MetaTitle { get; set; }
    }
}