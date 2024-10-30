using Microservices.Demo.Policy.API.Application;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Demo.Policy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliciesVersionController : ControllerBase
    {

        private readonly PolicyVersionApplicationService _policyVersionApplicationService;
        public PoliciesVersionController(PolicyVersionApplicationService policyVersionApplicationService)
        {
            _policyVersionApplicationService = policyVersionApplicationService;
        }
        // GET api/PoliciesVersions
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return new JsonResult(await _policyVersionApplicationService.GetAllAsync());
        }
    }
}
