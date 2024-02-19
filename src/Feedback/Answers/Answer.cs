using Feedback.Questions;

namespace Feedback.Answers;

public class Answer
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public int QuestionId { get; set; }
    public QuestionType Type { get; set; } = QuestionType.Text;
    public string Content { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; } = DateTime.Now;
}