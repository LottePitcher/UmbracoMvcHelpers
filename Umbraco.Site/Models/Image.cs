using System.ComponentModel;
using Our.Umbraco.Ditto;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace Umbraco.Site.Models
{
    [TypeConverter(typeof(DittoMediaPickerConverter))]
    public class Image : PublishedContentModel
    {
        public Image(IPublishedContent content) : base(content)
        {
        }

        [UmbracoProperty(Constants.Conventions.Media.Bytes)]
        public int Bytes { get; set; }

        [UmbracoProperty(Constants.Conventions.Media.Extension)]
        public string Extension { get; set; }

        // our custom field for storing alt text against each image
        public string AltText { get; set; }
    }
}