using InsuranceAssesment.Data_Layer.Entities;

namespace InsuranceAssesment.Data_Layer.Repository.IRepository
{
    public interface IPolicyRepository
    {
        Task<IEnumerable<Policy>> GetAllAsync();
    }
}
