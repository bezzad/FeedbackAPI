using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback.Answers;

public class File
{
    [Key] public Guid Id { get; set; }
    [MaxLength(128)] public string Name { get; set; } = string.Empty;
    [NotMapped] public byte[] Data { get; set; }
    [MaxLength(6)] public string? FileType { get; set; }
    public long? Length { get; set; }
    public long AnswerId { get; set; }
    public IssueAnswer Answer { get; set; }

}