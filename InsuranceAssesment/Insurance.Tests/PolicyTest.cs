using InsuranceAssesment.Data_Layer.Repository.IRepository;
using InsuranceAssesment.Business_Layer.Services;
using InsuranceAssesment.Data_Layer.Entities;
using Xunit;
using Moq;

namespace Insurance.Tests
{
    public class PolicyTest
    {
        public class PolicyServiceTests
        {
            private readonly Mock<IPolicyRepository> _mockRepo;
            private readonly PolicyService _service;

            public PolicyServiceTests()
            {
                _mockRepo = new Mock<IPolicyRepository>();
                var mockLogger = new Mock<ILogger<PolicyService>>();
                _service = new PolicyService(_mockRepo.Object, mockLogger.Object);
            }

            [Fact]
            public async Task GetAllAsync_ReturnsExpectedPolicies()
            {
                _mockRepo.Setup(x => x.GetAllAsync()).ReturnsAsync(new List<Policy>
        {
            new Policy { HolderName = "Alice", PolicyNumber = "P001" }
        });

                var result = await _service.GetAllAsync();

                Assert.Single(result);
                Assert.Equal("Alice", result.First().HolderName);
            }
        }

    }
}
