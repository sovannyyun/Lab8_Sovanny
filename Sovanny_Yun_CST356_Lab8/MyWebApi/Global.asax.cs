using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MyWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\SovannyTfk\Documents\Academic\CST356\Labs\Sovanny_Yun_CST356_Lab8\Sovanny_Yun_CST356_Lab3\App_Data");
        }
    }
}
