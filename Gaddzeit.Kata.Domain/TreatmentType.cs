using System;

namespace Gaddzeit.Kata.Domain
{
    public abstract class TreatmentType
    {
        protected TreatmentType()
        {
        }

        public abstract string CourseOfAction { get; }

        public static TreatmentType CreateTreatment(Treatment.TreatmentEnum treatmentEnum)
        {
            switch(treatmentEnum)
            {
                case Treatment.TreatmentEnum.Dietary:
                    return new Dietary();
                    break;
                case Treatment.TreatmentEnum.Hydration:
                    return new Hydration();
                    break;
                case Treatment.TreatmentEnum.Prescription:
                    return new Prescription();
                    break;
                case Treatment.TreatmentEnum.Referral:
                    return new Referral();
                    break;
                case Treatment.TreatmentEnum.Surgery:
                    return new Surgery();
                    break;
            }
            return null;
        }
    }
}