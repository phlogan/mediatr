using Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private MediatorDataContext _context;
        public UnitOfWork(MediatorDataContext context)
        {
            _context = context;
        }

        public IDbContextTransaction BeginTransaction() => _context.Database.BeginTransaction();

        public void Commit(IDbContextTransaction transaction) => transaction.Commit();

        public void Rollback(IDbContextTransaction transaction) => transaction.Rollback();

        public void SaveChanges() => _context.SaveChanges();
    }
}
