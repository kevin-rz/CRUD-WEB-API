using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebAPI.Models;

namespace BlogWebAPI.Repositories
{
    public class PostRepository
    {
        private List<PostModel> Posts = new List<PostModel>()
        {
          new PostModel { Id = 1, Tittle = "qwerty", Content="kljfdlksf lisdf liasdhf alasidj", UserId=5,  Date = DateTime.Now},
          new PostModel { Id = 2, Tittle = "poiuy", Content="ola k ase", UserId=1,  Date = DateTime.Now},
          new PostModel { Id = 3, Tittle = "mispl", Content="pasdo liksjd as asdffgh", UserId=3,  Date = DateTime.Now},
          new PostModel { Id = 4, Tittle = "boils", Content="flkjjhfd ihiosd i haf", UserId=2,  Date = DateTime.Now},
          new PostModel { Id = 5, Tittle = "dloisza", Content="kugk fdskug ajgw", UserId=4,  Date = DateTime.Now},
        };

        public List<PostModel> GetPosts()
        {
            return Posts;
        }

        public string AddPost(PostModel post)
        {
            Posts.Add(post);
            return "Post registered correctly";
        }

        public string EditPost(int id, PostModel post)
        {
            Posts[id] = post;
            return "Post edited correctly";
        }

        public string DeletePost(int id)
        {
            Posts.RemoveAt(id - 1);
            return "Post deleted correctly";
        }
    }
}
