﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesMovie.Pages
{
    public class TestFilterModel : PageModel
    {
        private readonly ILogger _logger;

        public TestFilterModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string Message { get; set; }

        public void OnGet()
        {
            _logger.LogDebug("TestFilterModel/OnGet");
        }

        public override void OnPageHandlerSelected(
                                    PageHandlerSelectedContext context)
        {
            _logger.LogDebug("TestFilterModel/OnPageHandlerSelected");
        }

        public override void OnPageHandlerExecuting(
                                    PageHandlerExecutingContext context)
        {
            Message = "Message set in handler executing";
            _logger.LogDebug("TestFilterModel/OnPageHandlerExecuting");
        }


        public override void OnPageHandlerExecuted(
                                    PageHandlerExecutedContext context)
        {
            _logger.LogDebug("TestFilterModel/OnPageHandlerExecuted");
        }
    }
}