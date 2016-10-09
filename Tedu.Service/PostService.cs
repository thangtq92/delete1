using System;
using System.Collections.Generic;
using Tedu.Data.Infrastructure;
using Tedu.Model.Models;
using TeduShop.Data.Repositories;

namespace Tedu.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalrow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pagesize, out int totalrow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pagesize, out int totalrow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pagesize, out int totalrow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetAllByTag(tag, page, pagesize, out totalrow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalrow, page, pagesize);
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pagesize, out int totalrow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalrow, page, pagesize, new string[] { "PostCategory" });
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

    }
}