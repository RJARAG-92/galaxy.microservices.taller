using Microservices.Demo.Report.API.Application;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportPolicyApplicationService _reportPolicyApplicationService;
        public ReportController(ReportPolicyApplicationService reportPolicyApplicationService)
        {
            _reportPolicyApplicationService = reportPolicyApplicationService;
        }
        // GET api/report/policy
        [HttpGet("policy")]
        public async Task<ActionResult> GetReportPolicy([FromHeader] string AgentLogin)
        {
            return new JsonResult(await _reportPolicyApplicationService.GetAllAsync(AgentLogin));
        }
    }
}
