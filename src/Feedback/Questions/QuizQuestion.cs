namespace Feedback.Questions;

public class QuizQuestion : Question
{
    public QuizOption[] Options { get; set; }

    public QuizQuestion()
    {
        Type = QuestionType.Quiz;
    }
}