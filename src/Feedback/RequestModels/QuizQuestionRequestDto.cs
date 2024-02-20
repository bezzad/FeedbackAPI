using System.ComponentModel.DataAnnotations;

namespace Feedback.Models;

public class QuizQuestionRequestDto : QuestionRequestDto
{
    public List<QuizOptionDto> Options { get; set; }
}