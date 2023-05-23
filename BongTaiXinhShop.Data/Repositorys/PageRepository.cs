using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;
namespace BongTaiXinhShop.Data.Repositorys
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
