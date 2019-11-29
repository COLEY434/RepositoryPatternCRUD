using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogApi.DTOS.WriteDTO;
using blogApi.Entities;
using blogApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blogApi.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IRepositoryUnitOfWork uow;
        public PostController(IRepositoryUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        } 

        // GET: api/Post
        [HttpGet]
        [Route("get-posts")]
        public async Task<IActionResult> GetPostsAsync()
        {
            try
            {
                var AllPost = await uow.post.GetPostsAsync();

                return Ok(AllPost);
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
           
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Post/create
        
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> createPostAsync(PostWriteDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var postData = new posts();
                    postData.user_id = model.user_Id;
                    postData.message = model.message;
                    postData.created_at = DateTime.Now;
                    postData.updated_at = null;

                uow.post.Create(postData);
                await uow.save();

                return Ok(new { success = true });
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
