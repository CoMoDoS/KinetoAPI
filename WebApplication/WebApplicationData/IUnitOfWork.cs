using System;
using WebApplicationData.Interfaces;

namespace WebApplicationData
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IPatientRepository PatientRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        ITreatmentRepository TreatmentRepository { get; }
        
    }
}