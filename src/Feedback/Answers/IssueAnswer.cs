using Feedback.Questions;

namespace Feedback.Answers;

public class IssueAnswer : Answer
{
    public byte[] Files { get; set; }

    public IssueAnswer()
    {
        Type = QuestionType.Issue;
    }
}