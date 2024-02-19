namespace Feedback;

public class Question
{
    public int Id { get; set; }
    public QuestionType Type { get; set; } = QuestionType.Text;
    public string Content { get; set; }
}

