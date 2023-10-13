using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Data.Repositorys;
using BongTaiXinhShop.Model.Model;

namespace BongTaiXinhShop.UniTest.RepositoryTest
{
    [TestClass]
    public class ClientCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IClientCategoryRepository clientCategoryRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            clientCategoryRepository = new ClientCategoryRepository(dbFactory);
            unitOfWork = new UnitOfwork(dbFactory);
        }
        [TestMethod]
        public void ClientCategory_Repository_Test()
        {
            ClientCategory clientCategory = new ClientCategory();
            clientCategory.Name = "Lê Văn Tùng";
            clientCategory.Name2 = "Tung Le Van";
            clientCategory.Phone = "0978366106";
            clientCategory.Status = true;
            clientCategory.Address = "Thôn 5 Thị Ngoại Tân Hòa Quốc Oai Hà Nội";
            var result = clientCategoryRepository.Add(clientCategory);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Id);
        }
    }
}
