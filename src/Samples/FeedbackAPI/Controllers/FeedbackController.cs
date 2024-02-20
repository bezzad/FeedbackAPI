using Feedback;
using Feedback.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FeedbackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly ILogger<FeedbackController> _logger;
        private readonly FeedbackService _feedbackService;

        public FeedbackController(ILogger<FeedbackController> logger, FeedbackService feedbackService)
        {
            _logger = logger;
            _feedbackService = feedbackService;
        }

        [HttpPost("EnsureCreated")]
        public async Task EnsureCreated()
        {
            await _feedbackService.EnsureCreatedAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetFeedback([Required] int id)
        {
            var result = await _feedbackService.GetFeedbackAsync(id);
            return Ok(result);
        }

        [HttpPost("text")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddQuestion([FromBody] Feedback.Models.Feedback model)
        {
            await _feedbackService.AddFeedback(model);
            return Ok();
        }

        [HttpPost("issue")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddQuestion([FromBody] Issue model)
        {
            await _feedbackService.AddFeedback(model);
            return Ok();
        }

        [HttpPost("rate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddQuestion([FromBody] Rate model)
        {
            await _feedbackService.AddFeedback(model);
            return Ok();
        }

        [HttpPost("quiz")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddQuestion([FromBody] Quiz model)
        {
            await _feedbackService.AddFeedback(model);
            return Ok();
        }
    }
}
