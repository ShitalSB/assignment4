using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Models.ActionFilters
{
    public class CrawlerAuhthentication : ActionFilterAttribute
    {
       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Browser.Crawler)
            {
                var url = new UrlHelper(filterContext.RequestContext);
                filterContext.Result = new RedirectResult(url.Action("Index", "Home"));
            }
        }
        
    }
}