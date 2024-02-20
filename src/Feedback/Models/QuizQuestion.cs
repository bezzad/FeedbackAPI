namespace Feedback.Models;

public class QuizQuestion : Question
{
    public IList<QuizOption> Options { get; set; }

    public QuizQuestion()
    {
        Type = QuestionType.Quiz;
        Options = new List<QuizOption>();
    }
}