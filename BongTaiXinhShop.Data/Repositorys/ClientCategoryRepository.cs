using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;

namespace BongTaiXinhShop.Data.Repositorys
{
    public interface IClientCategoryRepository : IRepository<ClientCategory>
    {
        IEnumerable<ClientCategory> GetAllByGroupId(string GroupId, int pageIndex, int pageSize, out int totalRow);
    }
    public class ClientCategoryRepository : RepositoryBase<ClientCategory>, IClientCategoryRepository
    {
        public ClientCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<ClientCategory> GetAllByGroupId(string GroupId, int pageIndex, int pageSize, out int totalRow)
        {
            IEnumerable<ClientCategory> query = from p in DbContext.clientCategories
                        where p.GroupClient1 == GroupId && p.Status
                        orderby p.Name
                        select p;

            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
