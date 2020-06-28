using System;
using System.Collections.Generic;
using System.Linq;
using zad11.DTO;
using zad11.Models;

namespace zad11.services
{
    public class EfCustomDbService
    {
        private readonly CustomDbContext _context;
        public EfCustomDbService(CustomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public void RemoveDoctor(int doctorId)
        {
            _context.Doctors.ToList().RemoveAll(d => d.IdDoctor == doctorId);
        }

        public void AddDoctor(DoctorRequest doctorRequest)
        {
            var doctor = new Doctor
            {
                FirstName = doctorRequest.FirstName,
                LastName = doctorRequest.LastName,
                Email = doctorRequest.Email
            };
            _context.Doctors.Add(doctor);
        }


        public void ModifyDoctor(DoctorRequest doctorRequest)
        {
            _context.Doctors.Where(d => d.IdDoctor == doctorRequest.IdDoctor).ToList().ForEach(d =>
            {
                d.FirstName = doctorRequest.FirstName;
                d.LastName = doctorRequest.LastName;
                d.Email = doctorRequest.Email;
            });
        }
    }
}
