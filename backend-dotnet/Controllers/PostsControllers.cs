using System.Collections.Generic;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("/")]
    [ApiController]
    public class PostsControllers : ControllerBase
    {
        private readonly PostService _postService;

        public PostsControllers(PostService postService)
        {
            _postService = postService;
        }

        [HttpGet("show")]
        public ActionResult<List<Post>> Get()
        {
            var post = _postService.Get();

            return post;
        }

        [HttpGet("{id:length(24)}", Name = "showId")]
        public ActionResult<Post> Get(string id)
        {
            var post = _postService.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPost("create")]
        public ActionResult<Post> Create(Post post)
        {
            _postService.Create(post);

            return CreatedAtRoute("create", new { id = post.Id.ToString() }, post);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Post postIn)
        {
            var post = _postService.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _postService.Update(id, postIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var post = _postService.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _postService.Remove(post.Id);

            return NoContent();
        }
    }
}