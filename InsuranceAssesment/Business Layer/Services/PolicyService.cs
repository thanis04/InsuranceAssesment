using InsuranceAssesment.Business_Layer.Services.IServices;
using InsuranceAssesment.Data_Layer.Repository.IRepository;
using InsuranceAssesment.Data_Layer.Entities.Dto;

namespace InsuranceAssesment.Business_Layer.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly IPolicyRepository _repo;
        private readonly ILogger<PolicyService> _logger;

        public PolicyService(IPolicyRepository repo, ILogger<PolicyService> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public async Task<IEnumerable<Data_Layer.Entities.Dto.PolicyDto>> GetAllAsync()
        {
            try
            {
                var entities = await _repo.GetAllAsync();
                return entities.Select(p => new PolicyDto
                {
                    HolderName = p.HolderName,
                    PolicyNumber = p.PolicyNumber
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to fetch policies.");
                throw;
            }
        }
    }
}
