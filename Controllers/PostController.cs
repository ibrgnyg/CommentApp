using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommentApp.Data;
using CommentApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommentApp.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _dbContext;
        private IHostingEnvironment _environment;
        public PostController(AppDbContext dbContext,IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }


        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List(int order )
        {
           
            return Ok(await _dbContext.posts.OrderByDescending(x=>x.CreatedDate).ToListAsync());
        }

        public async Task<IActionResult> Create(Post post,IFormFile file)
        {
            if(file!= null)
            {
                var path = Path.Combine(_environment.WebRootPath, "img", file.FileName);
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                post.Photo = file.FileName;
            }
            if(ModelState.IsValid)
            {
                post.CreatedDate = DateTime.Now;
                _dbContext.Add(post);
                await _dbContext.SaveChangesAsync();

            }
          
            return Ok(post);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id== null)
            {
                return BadRequest();
            }
            var delete = await _dbContext.posts.Include(x=> x.Comments).FirstOrDefaultAsync(x=>x.Id ==id);
            if(delete.Photo!= null)
            {
                var path = Path.Combine(_environment.WebRootPath, "img", delete.Photo);
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    System.IO.File.Delete(path);
           
                }

            }
            _dbContext.Remove(delete);
            await _dbContext.SaveChangesAsync();
            return Ok("ok");

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,Post post)
        {
            var find = await _dbContext.posts.FindAsync(id);
            find.Name = post.Name;
            await _dbContext.SaveChangesAsync();
            return Ok(find);
        }
        //View
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var details = await _dbContext.posts.FindAsync(id);
            _dbContext.Comments.ToList();
            return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> deta(int id)
        {
            var details = await _dbContext.posts.FindAsync(id);
            return Ok(details);
        }

        //filter
        [HttpGet]
        public async Task<IActionResult> Media(string photo)
        {
            var medialist = await _dbContext.posts.Where(x=>x.Photo!= null).ToListAsync();
            return Ok(medialist);
        }
        [HttpGet]
        public async Task<IActionResult> OldList()
        {
            var oldlist = await _dbContext.posts.OrderBy(x => x.CreatedDate).ToListAsync();
            return Ok(oldlist);
                
        }
        [HttpGet]
        public async Task<IActionResult> NewList()
        {
            var oldlist = await _dbContext.posts.OrderByDescending(x => x.CreatedDate).ToListAsync();
            return Ok(oldlist);

        }


        //Comment

        [HttpPost]
        public async Task<IActionResult> AddComment(int PostId,  string commentDes)
        {
            var comment = new Comment()
            {
                PostID =  PostId,
                CommentDes = commentDes,
                CreateDate = DateTime.Now,
           
            };
            comment.CommentCount++;
            _dbContext.Add(comment);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> CommentList(int id)
        {
            var list = await _dbContext.Comments.Where(x => x.PostID == id).OrderByDescending(x=> x.CreateDate).ToListAsync();
            return Ok(list);
        }
    }
}