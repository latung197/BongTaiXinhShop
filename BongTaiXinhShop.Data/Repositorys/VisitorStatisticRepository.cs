using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;

namespace BongTaiXinhShop.Data.Repositorys
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
