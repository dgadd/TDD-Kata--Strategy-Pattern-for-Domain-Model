using System;

namespace Gaddzeit.Kata.Domain
{
    public class Hydration : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Hydrate the pet."; }
        }
    }
}