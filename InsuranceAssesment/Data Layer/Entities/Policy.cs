namespace InsuranceAssesment.Data_Layer.Entities
{
    public class Policy
    {
        public int Id { get; set; }
        public required string HolderName { get; set; }
        public required string PolicyNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
