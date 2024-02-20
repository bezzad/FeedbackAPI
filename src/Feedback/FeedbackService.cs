using Feedback.Models;
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

    public async Task<Question?> GetQuestionAsync(int id)
    {
        return await _context.Questions.Where(q=> q.Id == id).AsNoTracking().SingleOrDefaultAsync();
    }

    public async Task<Models.Feedback?> GetFeedbackAsync(int id)
    {
        return await _context.Feedbacks.Where(q => q.Id == id).AsNoTracking().SingleOrDefaultAsync();
    }

    public async Task AddQuestion(Question question)
    {
        await _context.Questions.AddAsync(question);
        await _context.SaveChangesAsync();
    }

    public async Task AddFeedback(Models.Feedback answer)
    {
        await _context.Feedbacks.AddAsync(answer);
        await _context.SaveChangesAsync();
    }
}