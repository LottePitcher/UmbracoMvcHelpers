using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Umbraco.Site.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString DisplayForNumericWithUnit<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, string unit, string unitPlural = null)
        {
            if (String.IsNullOrEmpty(unitPlural)) unitPlural = unit + "s";

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            if (metadata.Model == null || String.IsNullOrEmpty(metadata.Model.ToString()))
                return new MvcHtmlString("");

            var value = Convert.ToDecimal(metadata.Model);
            return new MvcHtmlString(String.Format("{0} {1}", value, (value==1) ? unit : unitPlural));
        }

    }
}