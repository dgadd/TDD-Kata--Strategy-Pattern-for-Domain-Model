using System;
using System.Collections.Generic;

namespace Gaddzeit.Kata.Domain
{
    public class Pet : DomainEntity
    {
        public List<Treatment> Treatments { get; private set; }

        public Pet()
        {
            this.Treatments = new List<Treatment>();
        }

        public void AddTreatment(Treatment treatment)
        {
            this.Treatments.Add(treatment);
        }
    }
}