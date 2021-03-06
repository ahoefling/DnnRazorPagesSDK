﻿using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetNuke.Web.Mvc.RazorPages.SDK.NETFramework.Helpers
{
    public class DnnHtmlHelper<TModel> : DnnHtmlHelper
    {
        public DnnHtmlHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : this(viewContext, viewDataContainer, RouteTable.Routes)
        {
        }

        public DnnHtmlHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
            : base(new HtmlHelper<TModel>(viewContext, viewDataContainer, routeCollection))

        {
        }

        public new HtmlHelper<TModel> HtmlHelper => (HtmlHelper<TModel>)base.HtmlHelper;

        public new object ViewBag => HtmlHelper.ViewBag;

        public new ViewDataDictionary<TModel> ViewData => HtmlHelper.ViewData;
    }
}
