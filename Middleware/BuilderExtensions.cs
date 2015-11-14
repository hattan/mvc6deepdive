using Microsoft.AspNet.Builder;
using Microsoft.Framework.Configuration;

namespace DemoApp
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseIAMMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<IAMMiddleware>();
        }
    }
}