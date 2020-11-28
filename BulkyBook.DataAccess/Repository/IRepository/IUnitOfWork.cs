using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    //wrapper for unitOfWork
    public interface IUnitOfWork : IDisposable
    {
        //wrap things we want to wrap
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUserRepository { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
