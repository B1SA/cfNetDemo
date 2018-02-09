﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cfNetDemo.lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cfNetDemo.Pages
{
    public class IndexModel : PageModel
    {
        public string SL_SESSIONID { get; private set; }
        public string ENV_SERVER { get; private set; } = (Environment.GetEnvironmentVariable("INSTANCE_INDEX") + 1);
        public OData ITEM_LIST { get; private set; }
        public void OnGet()
        {
            SL_SESSIONID = serviceLayer.getSessionId();
            ITEM_LIST = serviceLayer.getItemsList();
            ITEM_LIST = ITEM_LIST;
        }
    }
}
