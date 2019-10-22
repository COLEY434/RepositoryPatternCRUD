using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blogApi.Entities;
using blogApi.DTOS.WriteDTO;
using blogApi.DAL.Login;
using blogApi.Interfaces;

namespace blogApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class usersController : ControllerBase
    {
        private IRepositoryUnitOfWork uow;
        public usersController(IRepositoryUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }


       // Gets all users 
       [HttpGet]
        public async Task<IActionResult> GetUsersAsync()
        {
            try
            {
                var users = await uow.user.GetAllUsersAsync();
                if (users == null)
                {
                    return NotFound();
                }

                return Ok(users);
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
           
        }


        //Get male users 
        [HttpGet]
        [Route("male")]
        public async Task<IActionResult> GetMalesUsersAsync()
        {
            try
            {
                var users = await uow.user.GetMaleUsers();
                if (users == null)
                {
                    return NotFound();
                }

                return Ok(users);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        // Gets users by id
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(long id)
        {
            try
            {
                var users = await uow.user.GetUserById(id);
                if (users == null)
                {
                    return NotFound();
                }

                return Ok(users);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // updates the user record
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUsersAsync(long id, UserWriteDTO user)
        {
            try
            {
                var users = await uow.user.GetUserByIdT(id);
                if (users != null)
                {

                    users.firstname = user.firstname;
                    users.surname = user.surname;
                    users.state = user.state;
                    users.gender = user.gender;
                    users.age = user.age;
                    users.updated_at = DateTime.Now;

                    uow.user.Update(users);
                    await uow.save();

                    return Ok(new { success = true });
                }

                return Ok(new { success = false, Message = "Failed to update"});
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // Creates the user record
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUserAsync(UserWriteDTO user)
        {

                try
                {
                    var userInfo = new users();

                    userInfo.firstname = user.firstname;
                    userInfo.surname = user.surname;
                    userInfo.state = user.state;
                    userInfo.gender = user.gender;
                    userInfo.age = user.age;
                    userInfo.created_at = DateTime.Now;

                    uow.user.Create(userInfo);
                    await uow.save();
                
                    return Ok(new { success = true });
                }
                catch (Exception ex)
                {
                    return Ok(ex.Message);
                }

        }








        //DELETE: 
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<users>> Deleteusers(long id)
        {
            try
            {
                var users = await uow.user.GetUserByIdT(id);
                if (users != null)
                {
                    uow.user.Delete(users);
                    await uow.save();

                    return Ok(new { success = true });
                }

                return Ok(new { success = false, Message = "Failed to delete"});
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
