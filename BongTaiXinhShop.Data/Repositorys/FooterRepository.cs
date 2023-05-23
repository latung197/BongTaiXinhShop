using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;
namespace BongTaiXinhShop.Data.Repositorys
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
