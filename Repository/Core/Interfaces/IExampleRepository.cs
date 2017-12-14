using Repository.Core.Domain;
using System.Collections.Generic;

namespace Repository.Core.Interfaces
{
    public interface IExampleRepository : IRepository<Example>
    {
        IEnumerable<Example> GetIndexedExamples(int pageIndex, int pageSize);
    }
}
