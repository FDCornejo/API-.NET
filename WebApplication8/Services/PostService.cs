using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class PostService
    {
        private PostRepository _postRepo;
        public PostService(PostRepository postRepository) {

            _postRepo = postRepository;
        }

        public List<PostModel> GetPosts() {
            return _postRepo.GetPosts();
        }

        public void AddPosts(PostModel post) {
            _postRepo.AddPost(post);
        }

        public PostModel SeePost(int numero) {
            return _postRepo.SeePost(numero);
        }
        public void EditPost(int id, PostModel newPost) => _postRepo.editPost(id, newPost);

        public void deletePost(int id) => _postRepo.deletePost(id);

    }
}
