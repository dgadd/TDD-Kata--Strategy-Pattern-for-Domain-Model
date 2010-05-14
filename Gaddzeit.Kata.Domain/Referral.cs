using System;

namespace Gaddzeit.Kata.Domain
{
    public class Referral : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Refer to another vetrinarian with specialization expertise."; }
        }
    }
}