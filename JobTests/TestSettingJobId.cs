using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTests
{
    [TestClass]
    public class TestSettingJobId
    {
        [TestMethod]
        public void JobIdsAreUnique()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }
    }

    [TestClass]
    public class TestJobConstructorSetsAllFields
    {
        [TestMethod]
        public void JobsHaveAllInfoFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            Assert.IsTrue(job1.JobCoreCompetency.Value == "Persistence");

            

        }



    }
}
