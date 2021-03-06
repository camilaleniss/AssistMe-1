﻿using Microsoft.AspNetCore.Mvc;
using AssistMeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistMeProject.ViewComponents
{
    public class TagWidgetViewComponent:ViewComponent
    {
        private readonly AssistMeProjectContext _context;

        public TagWidgetViewComponent(AssistMeProjectContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<string> tags = _context.Label.OrderByDescending(l => l.NumberOfTimes).Take(5).Select(x =>x.Tag);
           
            return View(tags);
        }


        
    }
}
