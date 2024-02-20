namespace Feedback.Models;

public class Issue : Feedback
{
    public bool Reviewed { get; set; } = false;
    public bool IsSeen { get; set; } = false;
    public IList<File> Files { get; set; }

    public Issue()
    {
        Type = QuestionType.Issue;
        Files = new List<File>();
    }
}