using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Umbraco.Site.Helpers
{
    public static class HtmlHelpers
    {
        /// <summary>
        /// If only one item display "X unit", otherwise display "X units"
        /// </summary>
        public static MvcHtmlString DisplayNumberWithUnitFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, string unit, string unitPlural = null)
        {
            if (String.IsNullOrEmpty(unitPlural)) unitPlural = unit + "s";

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            if (metadata.Model == null || String.IsNullOrEmpty(metadata.Model.ToString()))
                return new MvcHtmlString("");

            var value = Convert.ToDecimal(metadata.Model);
            return new MvcHtmlString(String.Format("{0} {1}", value, (value==1) ? unit : unitPlural));
        }

        /// <summary>
        /// Used by DisplayTemplate for properties flagged as [DataType(DataType.MultilineText)]
        /// </summary>
        public static MvcHtmlString DisplayForLineBreaks<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, string defaultIfEmpty = "")
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            if (metadata.Model == null || String.IsNullOrEmpty(metadata.Model.ToString()))
                return new MvcHtmlString(defaultIfEmpty);

            var model = htmlHelper.Encode(metadata.Model).Replace("\n", "<br />\n");
            return MvcHtmlString.Create(model);
        }
    }
}