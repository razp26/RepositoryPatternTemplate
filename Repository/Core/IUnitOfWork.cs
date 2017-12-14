using Repository.Core.Interfaces;
using System;

namespace Repository.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IExampleRepository Examples { get; }
        int Complete();
    }
}
