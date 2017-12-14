using Repository.Core;
using Repository.Core.Interfaces;
using Repository.Persistance.Repositories;

namespace Repository.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemoContext _context;

        public UnitOfWork(DemoContext context)
        {
            _context = context;
            Examples = new ExampleRepository(_context);
        }

        public IExampleRepository Examples { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
