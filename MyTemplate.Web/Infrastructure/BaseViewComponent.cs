﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTemplate.Web.Infrastructure
{
    //[Authorize]
    public class BaseViewComponent<T> : ViewComponent
    {
        protected BaseViewComponent()
        {

        }
    }
}
