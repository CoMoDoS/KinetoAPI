using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using KinetoAPI.Data.Entities;
using KinetoAPI.Data.Interfaces;

namespace KinetoAPI.Data.Repositories
{
    internal class UserRepository : RepositoryBase, IUserRepository
    {
        private const string USER_GET_BY_ID = "select * from cabinet.user where id = :Id";
        private const string USER_GET_ALL = "select * from cabinet.user";
        
        public UserRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<UserDto> GetByIdAsync(long id)
        {
            var parameters = new
            {
                Id = id
            };
            var user = await Connection.QueryAsync<UserDto>(
                sql: USER_GET_BY_ID,
                param: parameters,
                commandType: CommandType.Text,
                transaction: Transaction);

            return user?.FirstOrDefault();
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await Connection.QueryAsync<UserDto>(
                sql: USER_GET_ALL,
                commandType: CommandType.Text,
                transaction: Transaction);
            return users;
        }
    }
}