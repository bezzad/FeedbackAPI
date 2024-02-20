using System.ComponentModel.DataAnnotations;

namespace Feedback.Models;

public class QuizOption
{
    [Key] public int Id { get; set; }
    [MaxLength(1000)] public string Content { get; set; } = string.Empty;
    public IList<QuizQuestion> Questions { get; set; }

    public QuizOption()
    {
        Questions = new List<QuizQuestion>();
    }
}