using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FM.Packages
{
    public static class HtmlExtension
    {
        
        public static MvcHtmlString AjaxButton(this HtmlHelper helper, string label, AjaxButtonOptions options, object htmlAttributes = null)
        {
            TagBuilder tabBuilder = new TagBuilder("button");
            tabBuilder.MergeAttribute("type", "button");
            tabBuilder.MergeAttribute("class", "ajax-button");
            tabBuilder.AddCssClass(options.CssClass);

            tabBuilder.MergeAttribute("data-url", options.Url);
            tabBuilder.MergeAttribute("data-method", options.Method.ToUpper());
            tabBuilder.MergeAttribute("data-target-id", options.TargetId);
            tabBuilder.SetInnerText(label);
            if (htmlAttributes != null)
            {
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                tabBuilder.MergeAttributes(attributes);
            }

            return new MvcHtmlString(tabBuilder.ToString());
        }
    }
}
