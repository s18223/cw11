using System;
using System.Collections.Generic;
using zad11.Models;

namespace zad11
{
    public class CustomDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomDbContext>
    {
        public CustomDbInitializer()
        {
        }

        protected override void Seed(CustomDbContext context)
        {
            var doctors = new List<Doctor>
            {
                new Doctor{
                    IdDoctor=1,
                    FirstName="John",
                    LastName="Doe",
                    Email="john.doe@gmail.com"
                },
                new Doctor{
                    IdDoctor=2,
                    FirstName="Anna",
                    LastName="Doe",
                    Email="anna.doe@gmail.com"
                }
            };
            doctors.ForEach(d => context.Doctors.Add(d));
            context.SaveChanges();

            var patients = new List<Patient>
            {
                new Patient {
                    IdPatient=1,
                    FirstName="Mark",
                    LastName="Brown",
                    Birthdate=DateTime.Parse("1970-01-01")
                }
            };
            patients.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            var prescriptions = new List<Prescription>
            {
                new Prescription {
                    IdPrescription=1,
                    IdPatient=1,
                    IdDoctor=2,
                    DueDate=DateTime.Parse("2021-01-01"),
                    Date=DateTime.Today
                }
            };
            prescriptions.ForEach(p => context.Prescriptions.Add(p));
            context.SaveChanges();

            var medicaments = new List<Medicament>
            {
                new Medicament
                {
                    IdMedicament=1,
                    Name="Apap",
                    Description="Contains paracetamol",
                    Type="Anti pain"
                }
            };
            medicaments.ForEach(m => context.Medicaments.Add(m));
            context.SaveChanges();

            var prescriptionMedicaments = new List<PrescriptionMedicament>
            {
                new PrescriptionMedicament
                {
                    IdMedicament=1,
                    IdPrescription=1,
                    Dose=12,
                    Details="no details"
                }
            };
            prescriptionMedicaments.ForEach(m => context.PrescriptionMedicament.Add(m));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
