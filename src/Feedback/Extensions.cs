using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Feedback
{
    public static class Extensions
    {
        public static IServiceCollection AddFeedbackService(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<FeedbackService>();
            services.AddDbContext<FeedbackContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
