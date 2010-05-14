using System;

namespace Gaddzeit.Kata.Domain
{
    public class Surgery : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Perform surgery for pet."; }
        }
    }
}