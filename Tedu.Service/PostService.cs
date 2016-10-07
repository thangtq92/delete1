using System;
using System.Collections.Generic;
using Tedu.Data.Infrastructure;
using Tedu.Data.Repositories;
using Tedu.Model.Models;

namespace Tedu.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pagesize, int totalrow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(int page, int pagesize, int totalrow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllByTagPaging(int page, int pagesize, int totalrow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, int totalrow)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}