using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gaddzeit.Kata.Domain;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace Gaddzeit.Kata.Tests.Unit
{
    [TestFixture]
    public class TreatmentTypeTests
    {
        [Test]
        public void Constructors_Public_ShouldBeNone()
        {
            typeof(TreatmentType).GetConstructors()
                .Where(constructorInfo => constructorInfo.IsPublic).Count().ShouldEqual(0);
        }

        [Test]
        public void CreationMethod_SurgeryTreatmentEnumInput_ReturnsInstanceOfSurgery()
        {
            var surgeryTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Surgery);
            surgeryTreatment.ShouldBeInstanceOf<Surgery>();
            surgeryTreatment.ShouldBeInstanceOf<TreatmentType>();
        }

        [Test]
        public void CourseOfActionProperty_DietaryTreamentEnumInput_ReturnsDietaryCourseOfAction()
        {
            var sut = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Dietary);
            sut.CourseOfAction.ShouldEqual("Give dietary advice.");
        }

        [Test]
        public void CourseOfActionProperty_HydrationTreamentEnumInput_ReturnsHydrationCourseOfAction()
        {
            var sut = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Hydration);
            sut.CourseOfAction.ShouldEqual("Hydrate the pet.");
        }

        [Test]
        public void CourseOfActionProperty_PrescriptionTreamentEnumInput_ReturnsPrescriptionCourseOfAction()
        {
            var sut = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Prescription);
            sut.CourseOfAction.ShouldEqual("Prescribe an appropriate medication.");
        }

        [Test]
        public void CourseOfActionProperty_ReferralTreamentEnumInput_ReturnsReferralCourseOfAction()
        {
            var sut = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Referral);
            sut.CourseOfAction.ShouldEqual("Refer to another vetrinarian with specialization expertise.");
        }

        [Test]
        public void CourseOfActionProperty_SurgeryTreamentEnumInput_ReturnsSurgeryCourseOfAction()
        {
            var sut = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Surgery);
            sut.CourseOfAction.ShouldEqual("Perform surgery for pet.");
        }
    }
}
