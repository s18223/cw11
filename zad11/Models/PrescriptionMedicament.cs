using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace zad11.Models
{
    public class PrescriptionMedicament
    {
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }

        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }


        public int Dose { get; set; }

        public string Details { get; set; }
    }
}
