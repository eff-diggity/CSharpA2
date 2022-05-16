using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System.Collections.Generic;

namespace JobTests
{
    [TestClass]
    public class TestSettingJobId
    {
        [TestMethod]
        public void JobIdsAreUnique()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }



        [TestMethod]
        public void JobsHaveAllInfoFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality Control");
            Assert.IsTrue(job1.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void JobsWithSameIdAreEqual()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }



        [TestMethod]
        public void PrintoutHasBlankLinesAndAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), "\n" + $"ID: {job1.Id}\n" + "Name: Product tester\n" + "Employer: ACME\n" + "Location: Desert\n" + "Position Type: Quality Control\n" + "Core Competency: Persistence\n");

        }

        [TestMethod]
        public void NoDataForEmptyValue()
        {
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.AreEqual(job3.ToString(), "\n" + $"ID: {job3.Id}\n" + "Name: Ice cream tester\n" + "Employer: Data not available\n" + "Location: Home\n" + "Position Type: UX\n" + "Core Competency: Tasting ability\n");

        }


    }
}
