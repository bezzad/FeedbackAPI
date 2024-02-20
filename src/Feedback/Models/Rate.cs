namespace Feedback.Models;

public class Rate : Feedback
{
    public int Ratio { get; set; }

    public Rate()
    {
        Type = QuestionType.Rate;
    }
}