namespace Feedback;

public class Answer
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public int QuestionId { get; set; }
    public QuestionType Type { get; set; } = QuestionType.Text;
    public string Content { get; set; }
}