using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplicationData.Entities;
using WebApplicationData.Interfaces;

namespace WebApplicationData.Repositories
{
    internal class UserRepository : RepositoryBase, IUserRepository
    {
        private const string USER_GET_BY_ID = "select * from cabinet.user where id = :Id";
        
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
    }
}