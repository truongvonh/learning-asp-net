using LearningAspNetAPI.Models;
using LearningAspNetAPI.Models.common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace LearningAspNetAPI.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly TaskContext _taskContext;
        private readonly ILogger<TaskController> _logger;

        public TaskController(
            TaskContext context,
            ILogger<TaskController> logger
            )
        {
            _taskContext = context;
            _logger = logger;
        }

        // GET: api/Tasks
        [HttpGet]
        //public PageList<Models.Task> GetTask(QueryParameter queryParameter)
        public IActionResult GetTask(QueryParameter queryParameter)
        {
            var result = PageList<Models.Task>
                .ToPagedList(_taskContext.TaskItems, queryParameter.PageNumber, queryParameter.PageSize);

            _logger.LogInformation("3123");

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogInformation(id.ToString());
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
