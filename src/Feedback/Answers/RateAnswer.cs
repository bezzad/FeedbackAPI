using Feedback.Questions;

namespace Feedback.Answers;

public class RateAnswer : Answer
{
    public int Rate { get; set; }

    public RateAnswer()
    {
        Type = QuestionType.Rate;
    }
}