using Feedback;
using Feedback.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FeedbackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger<QuestionController> _logger;
        private readonly FeedbackService _feedbackService;

        public QuestionController(ILogger<QuestionController> logger, FeedbackService feedbackService)
        {
            _logger = logger;
            _feedbackService = feedbackService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetQuestion([Required] int id)
        {
            var result = await _feedbackService.GetQuestionAsync(id);
            return Ok(result);
        }

        [HttpPost("text")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddTextQuestion([FromBody] QuestionRequestDto question)
        {
            await _feedbackService.AddQuestion(question);
            return Ok();
        }

        [HttpPost("quiz")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddQuizQuestion([FromBody] QuizQuestionRequestDto question)
        {
            await _feedbackService.AddQuizQuestion(question);
            return Ok();
        }

        [HttpPost("rate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddRateQuestion([FromBody] QuestionRequestDto question)
        {
            await _feedbackService.AddQuestion(question);
            return Ok();
        }

        [HttpPost("issue")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> AddIssueQuestion([FromBody] QuestionRequestDto question)
        {
            await _feedbackService.AddQuestion(question);
            return Ok();
        }
    }
}
