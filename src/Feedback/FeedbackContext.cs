using Feedback.Answers;
using Feedback.Questions;
using Microsoft.EntityFrameworkCore;

namespace Feedback;

public class FeedbackContext : DbContext
{
    private readonly string _connectionString;

    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<QuizOption> QuizOptions { get; set; }

    public FeedbackContext(DbContextOptions<FeedbackContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString);
    }
}
