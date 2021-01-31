using System;
using KinetoAPI.Data.Interfaces;

namespace KinetoAPI.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IPatientRepository PatientRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        ITreatmentRepository TreatmentRepository { get; }
        
    }
}