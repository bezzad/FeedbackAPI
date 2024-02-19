using Feedback.Answers;
using Feedback.Questions;
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

    public async Task<Answer?> GetAnswerAsync(int id)
    {
        return await _context.Answers.Where(q => q.Id == id).AsNoTracking().SingleOrDefaultAsync();
    }

    public async Task AddQuestion(Question question)
    {
        await _context.Questions.AddAsync(question);
        await _context.SaveChangesAsync();
    }

    public async Task AddAnswer(Answer answer)
    {
        await _context.Answers.AddAsync(answer);
        await _context.SaveChangesAsync();
    }
}