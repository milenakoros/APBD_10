using APBD_10.Models;

namespace YourNamespace.Repositories;

public interface IRepository
{
    Task<Patient> GetPatientByNameAsync(string firstName, string lastName);
    Task AddPatientAsync(Patient patient);
    Task<Medicament> GetMedicamentByIdAsync(int id);
    Task AddPrescriptionAsync(Prescription prescription);
}