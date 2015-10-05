namespace Umbraco.Site.ModelInterfaces
{
    /// <summary>
    /// IBasePage interface used in Site.cshtml so any 'base' page property can be displayed in the master layout
    /// </summary>
    public interface IBasePage
    {
        string MetaTitle { get; set; }

        string MetaDescription { get; set; }

        bool UmbracoNaviHide { get; set; }
    }
}