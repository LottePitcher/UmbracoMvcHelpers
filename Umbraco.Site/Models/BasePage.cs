using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Site.ModelInterfaces;

namespace Umbraco.Site.Models
{
    /// <summary>
    /// All models inherit from BasePage, as all document types use the 'BasePage' composition
    /// </summary>
    public class BasePage : PublishedContentModel, IBasePage
    {
        public BasePage(IPublishedContent content) : base(content)
        {
        }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public bool UmbracoNaviHide { get; set; }
    }
}