using InsuranceAssesment.Data_Layer.Entities.Dto;

namespace InsuranceAssesment.Business_Layer.Services.IServices
{
    public interface IPolicyService
    {
        Task<IEnumerable<PolicyDto>> GetAllAsync();
    }
}
