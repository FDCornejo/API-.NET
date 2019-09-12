using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class ComentService
    {
        private ComentRepository _comentRepo;
        public ComentService(ComentRepository comentRepo) {
            _comentRepo = comentRepo;
        }

        public List<ComentModel> GetComents() {
            return _comentRepo.GetComment();
        }

        public void AddComents(ComentModel coment) {
            _comentRepo.AddComment(coment);
        }

        public ComentModel SeeComent(int numero) => _comentRepo.SeeComent(numero);


        public void EditComent(int numero, ComentModel coment) => _comentRepo.editComment(numero,coment);

        public void DeleteComent(int id) => _comentRepo.deleteComment(id);
    }
}
