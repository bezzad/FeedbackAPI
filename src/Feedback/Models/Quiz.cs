namespace Feedback.Models;

public class Quiz : Feedback
{
    public int OptionId { get; set; }
    public QuizOption Option { get; set; }

    public Quiz()
    {
        Type = QuestionType.Quiz;
    }
}