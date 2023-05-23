using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BongTaiXinhShop.Data.Infastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BongTaiXinhShopDbContext dbContext;
        public BongTaiXinhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new BongTaiXinhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }

}
