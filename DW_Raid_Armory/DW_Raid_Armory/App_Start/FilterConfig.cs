﻿using System.Web;
using System.Web.Mvc;

namespace DW_Raid_Armory
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
