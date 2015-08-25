using Microsoft.AspNet.SignalR;
using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(BreakingNewsDemo.Startup))]

namespace BreakingNewsDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string connectionString = "";
            GlobalHost.DependencyResolver.UseServiceBus(connectionString, "BreakingNews");

            app.MapSignalR();
        }
    }
}
