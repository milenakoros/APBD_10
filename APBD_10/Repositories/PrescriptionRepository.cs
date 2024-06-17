using APBD_10.Context;
using APBD_10.Models;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public PrescriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task<Patient> GetPatientByDetailsAsync(string firstName, string lastName, DateTime birthdate)
        {
            return await _context.Patients
                .FirstOrDefaultAsync(p => p.FirstName == firstName && p.LastName == lastName && p.Birthdate == birthdate);
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
        }

        public async Task<Medicament> GetMedicamentByIdAsync(int id)
        {
            return await _context.Medicaments.FindAsync(id);
        }

        public async Task AddPrescriptionAsync(Prescription prescription)
        {
            await _context.Prescriptions.AddAsync(prescription);
        }

        public async Task AddPrescriptionMedicamentAsync(Prescription_Medicament prescriptionMedicament)
        {
            await _context.Prescription_Medicaments.AddAsync(prescriptionMedicament);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}