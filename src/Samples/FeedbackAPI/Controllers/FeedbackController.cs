using Feedback;
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

        //[HttpGet(Name = "Question/{questionId}")]
        //public async Task<IActionResult> GetFeedbackQuestion(int questionId)
        //{
        //    var result = await _feedbackService.GetQuestionAsync(questionId);
        //    return Ok(result);
        //}

        //[HttpGet(Name = "Feedback/{answerId}")]
        //public async Task<IActionResult> GetFeedback(int answerId)
        //{
        //    var result = await _feedbackService.GetFeedbackAsync(answerId);
        //    return Ok(result);
        //}
    }
}
