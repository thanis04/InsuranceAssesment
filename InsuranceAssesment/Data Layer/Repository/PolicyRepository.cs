using InsuranceAssesment.Data_Layer.Repository.IRepository;
using InsuranceAssesment.Data_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsuranceAssesment.Data_Layer.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<PolicyRepository> _logger;

        public PolicyRepository(AppDbContext context, ILogger<PolicyRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Policy>> GetAllAsync()
        {
            try
            {
                return await _context.Policies.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching data from DB.");
                throw;
            }
        }
    }
}
