using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using KinetoAPI.Data.Entities;
using KinetoAPI.Data.Interfaces;

namespace KinetoAPI.Data.Repositories
{
    internal class PatientRepository : RepositoryBase, IPatientRepository
    {
        private const string PATIENT_GET_BY_ID = "select * from cabinet.patient where Id = :Id";
        private const string PATIENT_GET_ALL = "select * from cabinet.patient";
            
        public PatientRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<PatientDto> GetByIdAsync(long id)
        {
            var parameters = new
            {
                Id = id
            };
            var patient = await Connection.QueryAsync<PatientDto>(
                sql: PATIENT_GET_BY_ID,
                param: parameters,
                commandType: CommandType.Text,
                transaction: Transaction);

            return patient?.FirstOrDefault();
        }
        
        public async Task<IEnumerable<PatientDto>> GetAll()
        {
            var patients = await Connection.QueryAsync<PatientDto>(
                sql: PATIENT_GET_ALL,
                commandType: CommandType.Text,
                transaction: Transaction);
            return patients;
        }
    }
}