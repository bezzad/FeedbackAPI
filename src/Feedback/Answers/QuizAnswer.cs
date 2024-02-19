using Feedback.Questions;

namespace Feedback.Answers;

public class QuizAnswer : Answer
{
    public int OptionId { get; set; }
    public virtual QuizOption Option { get; set; }

    public QuizAnswer()
    {
        Type = QuestionType.Quiz;
    }
}