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
        ISP_Call SP_Call { get; }
    }
}
