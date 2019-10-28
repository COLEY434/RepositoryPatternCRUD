using blogApi.DTOS.ReadDTO;
using blogApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Interfaces.LoginManagement
{
    public interface IUsersRepository : IBaseRepository<users>
    {
        Task<IEnumerable<users>> GetAllUsersAsync();
        Task<users> GetUserById(long id);
        Task<users> GetUserByIdT(long id);
        Task<IEnumerable<MaleUserDTO>> GetMaleUsers();

        Task<loginId> ValidateUser(string password, string email);


    }
}
