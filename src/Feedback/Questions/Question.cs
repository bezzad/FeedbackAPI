using System.ComponentModel.DataAnnotations;

namespace Feedback.Questions;

public class Question
{
    [Key] public int Id { get; set; }
    public QuestionType Type { get; protected set; } = QuestionType.Text;
    [MaxLength(1000)] public string Content { get; set; } = string.Empty;
}

