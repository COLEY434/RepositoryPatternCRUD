using blogApi.DTOS.ReadDTO;
using blogApi.Entities;
using blogApi.Interfaces.LoginManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DAL.Login.LoginRepository
{
    public class UsersRepository : BaseRepository<users>, IUsersRepository
    {

        public UsersRepository(RepositoryContext _context):base(_context)
        {

        }

       

        public async Task<IEnumerable<users>> GetAllUsersAsync()
        {
            var result = await FindAll().ToListAsync();

            return result;
        }

        public async Task<users> GetUserById(long id)
        {
            var result = await FindByCondition(x => x.Id == id).SingleOrDefaultAsync();

            return result;
        }

        public async Task<loginId> ValidateUser(string password, string email)
        {
            var result = await FindByCondition(x => x.email == email && x.password == password)
                                               .Select(x => new loginId
                                               {
                                                 Id = x.Id
                                               }).SingleOrDefaultAsync();

            return result;
        }

        public async Task<users> GetUserByIdT(long id)
        {
            var result = await FindByConditionWithTracking(x => x.Id == id).SingleOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<MaleUserDTO>> GetMaleUsers()
        {
            string male = "male";
            var result = await FindByCondition(x => x.gender == male)
                .Select(x => new MaleUserDTO
                {
                    Id = x.Id,
                    gender = x.gender,
                    age = x.age,
                    firstname = x.firstname

                }).ToListAsync();

            return result;
        }

      
    }
}
