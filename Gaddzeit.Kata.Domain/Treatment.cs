namespace Gaddzeit.Kata.Domain
{
    public class Treatment : DomainEntity
    {
        private readonly TreatmentEnum _treatmentEnum;

        public enum TreatmentEnum
        {
            Dietary,
            Hydration,
            Prescription,
            Referral,
            Surgery
        }

        public Treatment(TreatmentEnum treatmentEnum)
        {
            _treatmentEnum = treatmentEnum;
        }

        public TreatmentType TreatmentType
        {
            get
            {
                return TreatmentType.CreateTreatment(_treatmentEnum);
            }
        }
    }
}