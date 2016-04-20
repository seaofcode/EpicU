using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatEverBruh.Startup))]
namespace WhatEverBruh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
