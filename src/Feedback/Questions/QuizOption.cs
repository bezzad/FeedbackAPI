namespace Feedback.Questions;

public class QuizOption
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public IList<QuizQuestion> Questions { get; set; }

    public QuizOption()
    {
        Questions = new List<QuizQuestion>();
    }
}