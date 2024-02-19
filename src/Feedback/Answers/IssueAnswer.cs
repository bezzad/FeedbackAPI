using Feedback.Questions;

namespace Feedback.Answers;

public class IssueAnswer : Answer
{
    public IList<File> Files { get; set; }

    public IssueAnswer()
    {
        Type = QuestionType.Issue;
        Files = new List<File>();
    }
}