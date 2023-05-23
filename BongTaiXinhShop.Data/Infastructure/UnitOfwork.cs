using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BongTaiXinhShop.Data.Infastructure
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private BongTaiXinhShopDbContext dbContext;

        public UnitOfwork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public BongTaiXinhShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
