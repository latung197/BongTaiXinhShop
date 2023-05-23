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
    public interface IProductService
    {
        Product Add(Product product);
        void Update(Product product);
        Product Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<Product> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Product GetById(int id);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllPagin(int page, int pageSize, int totalRow)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
