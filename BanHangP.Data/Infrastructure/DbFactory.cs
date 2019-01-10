namespace BanHangP.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BanHangPDbContext dbContext;

        public BanHangPDbContext Init()
        {
            return dbContext ?? (dbContext = new BanHangPDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}