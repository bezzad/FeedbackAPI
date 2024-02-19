namespace Feedback;

public class RateAnswer : Answer
{
    public int Rate { get; set; }

    public RateAnswer()
    {
        Type = QuestionType.Rate;
    }
}