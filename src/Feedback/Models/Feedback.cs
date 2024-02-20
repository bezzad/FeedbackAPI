using System.ComponentModel.DataAnnotations;

namespace Feedback.Models;

public class Feedback
{
    [Key]
    public long Id { get; set; }
    public long UserId { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; }
    public QuestionType Type { get; protected set; } = QuestionType.Text;
    [MaxLength(1000)] public string Content { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; } = DateTime.Now;
}