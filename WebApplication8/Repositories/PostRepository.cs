using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class PostRepository
    {
        private List<PostModel> _Post = new List<PostModel>();

        public List<PostModel> GetPosts() {
            return _Post;
        }
        public void AddPost(PostModel posteo) {
            _Post.Add(posteo);
        }

        public PostModel SeePost(int numero)
        {
            return _Post.Find(e => e.Id.Equals(numero));
        }
        public void deletePost(int id) {
            _Post.Remove(SeePost(id));
        }

        public void editPost(int id, PostModel edition) {
            var thepost = SeePost(id);
            thepost.postData = edition.postData;
        }
    }
}
