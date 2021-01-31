using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using KinetoAPI.Data.Entities;
using KinetoAPI.Data.Interfaces;

namespace KinetoAPI.Data.Repositories
{
    internal class AppointmentRepository : RepositoryBase, IAppointmentRepository
    {
        private const string APPOINTMENT_GET_BY_ID = "select * from cabinet.appointment where Id = :Id";
        private const string APPOINTMENT_GET_ALL = "select * from cabinet.appointment";
        
        public AppointmentRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<AppointmentDto> GetByIdAsync(long id)
        {
            var parameters = new
            {
                Id = id
            };
            var appointment = await Connection.QueryAsync<AppointmentDto>(
                sql: APPOINTMENT_GET_BY_ID,
                param: parameters,
                commandType: CommandType.Text,
                transaction: Transaction);

            return appointment?.FirstOrDefault();
        }
        
        public async Task<IEnumerable<AppointmentDto>> GetAll()
        {
            var appointments = await Connection.QueryAsync<AppointmentDto>(
                sql: APPOINTMENT_GET_ALL,
                commandType: CommandType.Text,
                transaction: Transaction);
            return appointments;
        }
    }
}