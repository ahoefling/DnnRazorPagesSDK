﻿using DotNetNuke.Web.Mvc.RazorPages.SDK.NETFramework.Helpers;
using System.Web.Mvc;

namespace DotNetNuke.Web.Mvc.RazorPages.SDK.NETFramework
{
    public abstract class DnnWebViewPage<TModel> : WebViewPage<TModel>
    {
        public DnnHelper<TModel> Dnn { get; set; }

        public new DnnHtmlHelper<TModel> Html { get; set; }

        public new DnnUrlHelper Url { get; set; }

        public override void InitHelpers()
        {
            Ajax = new AjaxHelper<TModel>(ViewContext, this);
            Html = new DnnHtmlHelper<TModel>(ViewContext, this);
            Url = new DnnUrlHelper(ViewContext);
            Dnn = new DnnHelper<TModel>(ViewContext, this);
        }
    }
}
