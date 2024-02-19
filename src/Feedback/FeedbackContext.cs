using Feedback.Answers;
using Feedback.Questions;
using Microsoft.EntityFrameworkCore;

namespace Feedback;

internal class FeedbackContext : DbContext
{
    private readonly string _connectionString;

    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<QuizOption> QuizOptions { get; set; }

    public FeedbackContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}
