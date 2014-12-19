﻿using MVC5Final.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVC5Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogToDBAttribute());
        }
    }
}
