using APBD_10.Models;

namespace YourNamespace.Repositories
{
    public interface IPrescriptionRepository
    {
        Task<Patient> GetPatientByIdAsync(int id);
        Task<Patient> GetPatientByDetailsAsync(string firstName, string lastName, DateTime birthdate);
        Task AddPatientAsync(Patient patient);
        Task<Medicament> GetMedicamentByIdAsync(int id);
        Task AddPrescriptionAsync(Prescription prescription);
        Task AddPrescriptionMedicamentAsync(Prescription_Medicament prescriptionMedicament);
        Task<bool> SaveChangesAsync();
    }
}