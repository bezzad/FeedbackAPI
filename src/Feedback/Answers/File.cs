using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback.Answers;

public class File
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [NotMapped] public byte[] Data { get; set; }
    public string? FileType { get; set; }
    public long? Length { get; set; }
    public IList<IssueAnswer> Answers { get; set; }

    public File()
    {
        Answers = new List<IssueAnswer>();
    }
}