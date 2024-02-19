using Feedback.Questions;

namespace Feedback.Answers;

public class QuizAnswer : Answer
{
    public int OptionId { get; set; }
    public QuizOption Option { get; set; }

    public QuizAnswer()
    {
        Type = QuestionType.Quiz;
    }
}