using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SPA.APIV2._0.Startup))]

namespace SPA.APIV2._0
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            // Allow Cors 
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
        }
    }
}
