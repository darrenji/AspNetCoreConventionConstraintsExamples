using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreConventionAndConstraintsExample.Infrastructure
{
    /// <summary>
    /// IActionModelConvention改变Action的Convention
    /// </summary>
    public class ActionNamePrefixAttribute : Attribute, IActionModelConvention
    {
        private string namePrefix;

        public ActionNamePrefixAttribute(string prefix)
        {
            namePrefix = prefix;
        }
        public void Apply(ActionModel action)
        {
            action.ActionName = namePrefix + action.ActionName;
        }
    }
}
