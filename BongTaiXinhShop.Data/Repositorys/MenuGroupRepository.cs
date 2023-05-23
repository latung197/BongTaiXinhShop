using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Model.Model;

namespace BongTaiXinhShop.Data.Repositorys
{
    public interface IMenuGroupRepository: IRepository<MenuGroup>
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
