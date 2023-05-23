using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Repositorys;
using BongTaiXinhShop.Data.Infastructure;
using Moq;

namespace BongTaiXinhShop.UniTest.ServiceTest
{
    [TestClass]
     public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockReponsitory;
        private Mock<IUnitOfWork> _mockUniOfwork;
        [TestInitialize]
        public void Initialize()
        {
            _mockReponsitory = new Mock<IPostCategoryRepository>();
            _mockUniOfwork = new Mock<IUnitOfWork>();
            
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {

        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {

        }
    }
}
