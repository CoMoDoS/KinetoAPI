using System;
using WebApplicationData.Interfaces;

namespace WebApplicationData
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
    }
}