using InsuranceAssesment.Business_Layer.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceAssesment.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoliciesCotroller : ControllerBase
    {
        private readonly IPolicyService _service;

        public PoliciesCotroller(IPolicyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }
    }
}
