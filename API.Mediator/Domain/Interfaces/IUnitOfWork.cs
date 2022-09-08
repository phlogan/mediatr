using Microsoft.EntityFrameworkCore.Storage;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IDbContextTransaction BeginTransaction();
        void Commit(IDbContextTransaction transaction);
        void Rollback(IDbContextTransaction transaction);

    }
}
