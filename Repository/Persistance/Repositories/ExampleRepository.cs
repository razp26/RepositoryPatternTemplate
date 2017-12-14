using Repository.Core.Domain;
using Repository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistance.Repositories
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(DemoContext context) : base(context)
        {

        }

        public IEnumerable<Example> GetIndexedExamples(int pageIndex, int pageSize = 10)
        {
            return DemoContext.Examples
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public DemoContext DemoContext
        {
            get { return Context as DemoContext; }
        }
    }
}
