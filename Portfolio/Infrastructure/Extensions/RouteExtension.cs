namespace Portfolio.Infrastructure.Extensions
{
    public static class RouteExtension
    {
        public static IEndpointRouteBuilder MapCustomAdminRoute(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "{controller=AdminHome}/{action=Index}/{id?}"
            );
            return endpoints;
        }

        public static IEndpointRouteBuilder MapCustomDefaultRoute(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );
            return endpoints;
        }

    }
}
