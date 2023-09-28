using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Model.Model;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Data.Repositorys;

namespace BongTaiXinhShop.Service
{
    public interface IClientCategoryService
    {
        ClientCategory Add(ClientCategory clientCategory);
        void Update(ClientCategory clientCategory);
        ClientCategory Delete(int Id);
        IEnumerable<ClientCategory> GetAll();
        IEnumerable<ClientCategory> GetAllByGroupId(string GroupId, int pageIndex, int pageSize, out int totalRow);
        ClientCategory getById(int Id);
        void SaveChanges();
        void Save();
    }
    public class ClientCategoryService: IClientCategoryService
    {
        IClientCategoryRepository _clientCategoryRepository;
        IUnitOfWork _unitOfWork;
        public ClientCategoryService( IClientCategoryRepository clientCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._clientCategoryRepository = clientCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public ClientCategory Add(ClientCategory clientCategory)
        {
            return _clientCategoryRepository.Add(clientCategory);
        }

        public ClientCategory Delete(int Id)
        {
            return _clientCategoryRepository.Delete(Id);
        }

        public IEnumerable<ClientCategory> GetAll()
        {
            return _clientCategoryRepository.GetAll();
        }

        public IEnumerable<ClientCategory> GetAllByGroupId(string GroupId, int pageIndex, int pageSize, out int totalRow)
        {
            return _clientCategoryRepository.GetAllByGroupId(GroupId, pageIndex,pageSize,out totalRow);
        }


        public ClientCategory getById(int Id)
        {
            return _clientCategoryRepository.GetSingleById(Id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ClientCategory clientCategory)
        {
            _clientCategoryRepository.Update(clientCategory);
        }
    }
}
