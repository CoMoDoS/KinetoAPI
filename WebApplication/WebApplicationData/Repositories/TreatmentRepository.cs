using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplicationData.Entities;
using WebApplicationData.Interfaces;

namespace WebApplicationData.Repositories
{
    internal class TreatmentRepository : RepositoryBase, ITreatmentRepository
    {
        private const string TREATMENT_GET_BY_ID = "select * from cabinet.treatment where Id = :Id";
        private const string TREATMENT_GET_ALL = "select * from cabinet.treatment";
        public TreatmentRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<TreatmentDto> GetByIdAsync(long id)
        {
            var parameters = new
            {
                Id = id
            };
            var treatment = await Connection.QueryAsync<TreatmentDto>(
                sql: TREATMENT_GET_BY_ID,
                param: parameters,
                commandType: CommandType.Text,
                transaction: Transaction);

            return treatment?.FirstOrDefault();
        } 
        
        public async Task<IEnumerable<TreatmentDto>> GetAll()
        {
            var treatments = await Connection.QueryAsync<TreatmentDto>(
                sql: TREATMENT_GET_ALL,
                commandType: CommandType.Text,
                transaction: Transaction);
            return treatments;
        }
    }
}