using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IUnitOfWorkBase : IDisposable
    {
        DbContext Context { get; }

        int Save();

    }
}
