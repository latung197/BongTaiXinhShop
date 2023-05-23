using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;
using BongTaiXinhShop.Data.Repositorys;

namespace BongTaiXinhShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        IEnumerable<PostCategory> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<PostCategory> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        IEnumerable<PostCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        PostCategory GetById(int id);
        void SaveChanges();
        void Save();
    }

    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postCategoryRepository.GetMultiPaging(x => x.Status && x.ID == categoryId, out totalRow, page, pageSize);
        }


        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public IEnumerable<PostCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<PostCategory> GetAllPagin(int page, int pageSize, int totalRow)
        {
            return _postCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}
