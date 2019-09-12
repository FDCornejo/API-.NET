using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;


namespace WebApplication8.Repositories
{
    public class ComentRepository
    {
        private List<ComentModel> _Coment = new List<ComentModel>();


        public List<ComentModel> GetComment()
        {
            return _Coment;
        }
        public void AddComment(ComentModel comentario) {
            _Coment.Add(comentario);
        }

        public ComentModel SeeComent(int id) => _Coment.Find(e => e.Id.Equals(id));

        public void deleteComment(int id) => _Coment.Remove(SeeComent(id));

        public void editComment(int id, ComentModel newComent) {
            var theComent = SeeComent(id);
            theComent.theComment=newComent.theComment;
        }





    }
}
