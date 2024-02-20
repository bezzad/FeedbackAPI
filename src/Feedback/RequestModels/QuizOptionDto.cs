using System.ComponentModel.DataAnnotations;

namespace Feedback.Models;

public class QuizOptionDto
{
    [MaxLength(1000)] public string Content { get; set; } = string.Empty;
}