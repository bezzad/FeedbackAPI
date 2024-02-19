using Feedback;
using Feedback.Questions;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly ILogger<FeedbackController> _logger;
        private readonly FeedbackService _feedbackService;

        public FeedbackController(ILogger<FeedbackController> logger, FeedbackService feedbackService)
        {
            _logger = logger;
            _feedbackService = feedbackService;
        }

        [HttpGet(Name = "EnsureCreated")]
        public async Task EnsureCreated()
        {
            await _feedbackService.EnsureCreatedAsync();
        }

        [HttpGet(Name = "Question/{questionId}")]
        public async Task<IActionResult> GetFeedbackQuestion(int questionId)
        {
            var result = await _feedbackService.GetQuestionAsync(questionId);
            return Ok(result);
        }

        [HttpGet(Name = "Answer/{answerId}")]
        public async Task<IActionResult> GetAnswer(int answerId)
        {
            var result = await _feedbackService.GetAnswerAsync(answerId);
            return Ok(result);
        }
    }
}
