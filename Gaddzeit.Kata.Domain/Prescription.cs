using System;

namespace Gaddzeit.Kata.Domain
{
    public class Prescription : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Prescribe an appropriate medication."; }
        }
    }
}