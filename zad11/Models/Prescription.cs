using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zad11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }


        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Patient")]
        public int IdPatient { get; set; }

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
    }
}
