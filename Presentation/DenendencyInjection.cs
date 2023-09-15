using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class DenendencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}
