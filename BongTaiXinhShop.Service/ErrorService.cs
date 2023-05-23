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
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _ErrorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._ErrorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _ErrorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
