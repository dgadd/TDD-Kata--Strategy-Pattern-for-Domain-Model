using System;

namespace Gaddzeit.Kata.Domain
{
    public class Dietary : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Give dietary advice."; }
        }
    }
}