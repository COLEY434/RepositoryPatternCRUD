using blogApi.Interfaces.LoginManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Interfaces
{
    public interface IRepositoryUnitOfWork
    {
        IUsersRepository user { get; }
        IPostRepository post { get; }
        Task save();
    }
}
