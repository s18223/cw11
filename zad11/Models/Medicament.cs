using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zad11.Models
{
    public class Medicament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
