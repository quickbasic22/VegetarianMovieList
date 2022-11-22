using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Microsoft.AspNetCore.Html;

namespace CustomeHtmlHelper
{
    public static class CustomeImageHelper
    {
        public static HtmlString Image(this System.Web.Mvc.HtmlHelper helper, string id, string src, string alt, string height, string width)
        {
            // Below line is used for generate new tag with img  
            var builder = new TagBuilder("img");

            // Below five lines are used for adding atrribute for img tag  
            builder.MergeAttribute("id", id);

            builder.MergeAttribute("src", src);

            builder.MergeAttribute("alt", alt);

            builder.MergeAttribute("height", height);

            builder.MergeAttribute("width", width);

            // this method will return MVChtmlstring and Create method will render as selfclosing tag.  
            
            return new HtmlString("value");
        }
    }
}