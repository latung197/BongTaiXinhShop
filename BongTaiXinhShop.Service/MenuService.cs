using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Data.Repositorys;
using BongTaiXinhShop.Model.Model;


namespace BongTaiXinhShop.Service
{
    public interface IMenuService
    {
        Menu Add(Menu menu);
        void Update(Menu menu);
        Menu Delete(int id);
        IEnumerable<Menu> GetAll();
        IEnumerable<Menu> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<Menu> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<Menu> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Menu GetById(int id);
        void SaveChanges();
    }
    public class MenuService : IMenuService
    {

        IMenuRepository _menuRepository;
        IUnitOfWork _unitOfWork;
        public MenuService(IMenuRepository menuRepository, IUnitOfWork unitOfWork)
        {
            this._menuRepository = menuRepository;
            this._unitOfWork = unitOfWork;
        }



        public Menu Add(Menu menu)
        {
            return _menuRepository.Add(menu);
        }

        public Menu Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAllPagin(int page, int pageSize, int totalRow)
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Menu menu)
        {
            _menuRepository.Update(menu);
        }
    }
}
