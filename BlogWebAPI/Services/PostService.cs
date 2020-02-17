using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebAPI.Repositories;
using BlogWebAPI.Models;

namespace BlogWebAPI.Services
{
    public class PostService
    {
        private PostRepository _blogRepository;

        public PostService(PostRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<PostModel> GetPosts()
        {
            return _blogRepository.GetPosts();
        }

        public string AddPost(PostModel post)
        {
            return _blogRepository.AddPost(post);
        }

        public string EditPost(int id, PostModel post)
        {
            return _blogRepository.EditPost(id, post);
        }

        public string DeletePost(int id)
        {
            return _blogRepository.DeletePost(id);
        }
    }
}