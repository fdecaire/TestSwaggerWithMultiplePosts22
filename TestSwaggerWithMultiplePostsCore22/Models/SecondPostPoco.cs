namespace TestSwaggerWithMultiplePostsCore22.Models
{
    public class SecondPostPoco
    {
        public string ApplicationId { get; set; }

        public OtherModels.SubPoco Applicant { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ApplicationTypeId { get; set; }
    }
}
