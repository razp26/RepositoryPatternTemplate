using Repository.Persistance;
using System.Collections.Generic;

namespace Repository.Migrations
{
    using Repository.Core.Domain;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoContext context)
        {
            #region Add Examples
            var examples = new Dictionary<string, Example>
            {
                {"c#", new Example {Id = 1, Name = "c#"}},
                {"angularjs", new Example {Id = 2, Name = "angularjs"}},
                {"javascript", new Example {Id = 3, Name = "javascript"}},
                {"nodejs", new Example {Id = 4, Name = "nodejs"}},
                {"oop", new Example {Id = 5, Name = "oop"}},
                {"linq", new Example {Id = 6, Name = "linq"}},
            };

            foreach (var example in examples.Values)
                context.Examples.AddOrUpdate(t => t.Id, example);
            #endregion
        }
    }
}
