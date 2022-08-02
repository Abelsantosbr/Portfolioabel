using Microsoft.AspNetCore.HttpOverrides;

namespace PortfolioAbelCoreMvc
{
    internal class OverrideHeaderMiddlewareOptions
    {
        public ForwardedHeaders ForwardedOptions { get; set; }
    }
}