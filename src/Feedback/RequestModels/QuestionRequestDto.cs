using System.ComponentModel.DataAnnotations;

namespace Feedback.Models;

public class QuestionRequestDto
{
    [MaxLength(1000)] public string Content { get; set; } = string.Empty;
}