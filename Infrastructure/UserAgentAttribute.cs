using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreConventionAndConstraintsExample.Infrastructure
{
    public class UserAgentAttribute : Attribute, IActionConstraint
    {
        private string substring;

        public UserAgentAttribute(string sub)
        {
            substring = sub;
        }
        public int Order { get; set; } = 0;


        public bool Accept(ActionConstraintContext context)
        {
            return context.RouteContext.HttpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains(substring));
        }
    }
}
