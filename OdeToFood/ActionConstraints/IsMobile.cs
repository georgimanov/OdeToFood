namespace OdeToFood.ActionConstraints
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc.ActionConstraints;

    public class IsMobile : Attribute, IActionConstraint
    {
        public int Order => 0;

        public bool Accept(ActionConstraintContext context)
        {
            var isAccepted = context
                .RouteContext
                .HttpContext
                .Request
                .Headers["User-Agent"]
                .Any(x => x.Contains("Android"));

            return isAccepted;
        }
    }
}
