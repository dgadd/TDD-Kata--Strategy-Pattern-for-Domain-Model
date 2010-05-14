using Gaddzeit.Kata.Domain;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace Gaddzeit.Kata.Tests.Unit
{
    [TestFixture]
    public class PetTests
    {
        [Test]
        public void Constructor_NoInputParams_IsInstanceOfDomainEntity()
        {
            var sut = new Pet();
            sut.ShouldBeInstanceOf<DomainEntity>();
        }

        [Test]
        public void TreatmentsProperty_Get_HasCountOf0Initially()
        {
            var sut = new Pet();
            sut.Treatments.Count.ShouldEqual(0);
        }

        [Test]
        public void AddTreatmentMethod_PetInputParam_IncremantsTreatmentsCount()
        {
            var sut = new Pet();
            sut.Treatments.Count.ShouldEqual(0);
            sut.AddTreatment(new Treatment(Treatment.TreatmentEnum.Hydration));
            sut.Treatments.Count.ShouldEqual(1);
        }

    }
}
