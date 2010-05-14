using Gaddzeit.Kata.Domain;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace Gaddzeit.Kata.Tests.Unit
{
    [TestFixture]
    public class TreatmentTests
    {
        [Test]
        public void Constructor_NoInputParams_IsInstanceOfDomainEntity()
        {
            var sut = new Treatment(Treatment.TreatmentEnum.Surgery);
            sut.ShouldBeInstanceOf<DomainEntity>();
        }

        [Test]
        public void Constructor_TreatmentEnumParam_ReturnsCorrectCourseOfActionProperty()
        {
            var sut = new Treatment(Treatment.TreatmentEnum.Dietary);
            sut.TreatmentType.CourseOfAction.ShouldEqual("Give dietary advice.");
        }
    }
}
