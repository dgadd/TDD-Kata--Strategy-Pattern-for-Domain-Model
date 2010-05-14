using Gaddzeit.Kata.Domain;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace Gaddzeit.Kata.Tests.Unit
{
    [TestFixture]
    public class DomainEntityTests
    {
        [Test]
        public void TwoInstances_SameIdPropertySet_AreEqual()
        {
            const int commonId = 32753;
            var sut1 = new DomainEntity {Id = commonId};
            var sut2 = new DomainEntity {Id = commonId};

            sut1.ShouldEqual(sut2);
        }

        [Test]
        public void TwoInstances_DifferentIdPropertySet_AreNotEqual()
        {
            var sut1 = new DomainEntity { Id = 4275 };
            var sut2 = new DomainEntity { Id = 3214 };

            sut1.ShouldNotEqual(sut2);
        }

    }
}
