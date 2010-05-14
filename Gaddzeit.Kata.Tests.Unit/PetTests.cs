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
    }
}
