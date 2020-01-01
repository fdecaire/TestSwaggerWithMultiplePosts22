using System.Collections.Generic;

namespace TestSwaggerWithMultiplePostsCore22.Models
{
    public class FirstPostPoco
    {
        public string ApplicationId { get; set; }

        public List<SubPoco> applicantFollowUpData { get; set; }

        public int applicationTypeId { get; set; }
    }
}
