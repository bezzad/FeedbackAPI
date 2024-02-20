using Feedback.Models;
using Mapster;
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
        return await _context.Questions.AsNoTracking().Where(q=> q.Id == id).SingleOrDefaultAsync();
    }

    public async Task<Models.Feedback?> GetFeedbackAsync(int id)
    {
        return await _context.Feedbacks.AsNoTracking().Where(q => q.Id == id).SingleOrDefaultAsync();
    }

    public async Task<QuizOption?> GetQuizOptionAsync(int id)
    {
        return await _context.QuizOptions.AsNoTracking().Where(q => q.Id == id).SingleOrDefaultAsync();
    }

    public async Task AddIssueQuestion(QuestionRequestDto questionReq)
    {
        var question = questionReq.Adapt<Question>();
        await AddQuestionAsync(question);
    }

    public async Task AddQuestion(QuestionRequestDto questionReq)
    {
        var question = questionReq.Adapt<Question>();
        await AddQuestionAsync(question);
    }

    public async Task AddRateQuestion(QuestionRequestDto questionReq)
    {
        var question = questionReq.Adapt<RateQuestion>();
        await AddQuestionAsync(question);
    }

    public async Task AddQuizQuestion(QuizQuestionRequestDto questionReq)
    {
        var question = questionReq.Adapt<QuizQuestion>();
        await AddQuestionAsync(question);
    }

    private async Task AddQuestionAsync(Question entity)
    {
        _context.Questions.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task AddFeedback(Models.Feedback feedback)
    {
        _context.Feedbacks.Add(feedback);
        await _context.SaveChangesAsync();
    }

    public async Task AddOption(QuizOptionDto option)
    {
        var opt = option.Adapt<QuizOption>();
        _context.QuizOptions.Add(opt);
        await _context.SaveChangesAsync();
    }

}