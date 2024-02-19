using Microsoft.EntityFrameworkCore;

namespace Feedback;

public class FeedbackService
{
    private readonly FeedbackContext _context;

    public FeedbackService(FeedbackContext context)
    {
        _context = context;
    }

    public async Task EnsureCreatedAsync()
    {
        //creates db if not exists 
        await _context.Database.MigrateAsync();
    }
}