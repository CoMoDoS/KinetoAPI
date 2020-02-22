using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using Npgsql;
using WebApplicationCommon.Settings;
using WebApplicationData.Interfaces;
using WebApplicationData.Repositories;

namespace WebApplicationData
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        private readonly AppSettings _appSettings;

        private IUserRepository _userRepository;
        
        public UnitOfWork(IOptions<AppSettings> appSettings )
        {
            AppSettings appSettings1;
            _appSettings = appSettings.Value;

            _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=cabinet;User Id=postgres;Password=postgres");
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(_transaction));

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }

                _disposed = true;
            }
        }

        private void ResetRepositories()
        {
            _userRepository = null;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}