using System;

namespace BanHangP.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BanHangPDbContext Init();
    }
}