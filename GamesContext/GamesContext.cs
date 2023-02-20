using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using GameDll;
namespace GamesContext
{
    public class GamesContextClass : DbContext
 {
       public DbSet<GamesClass> gamesSet { get; set; }

        public GamesContextClass(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public GamesContextClass(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public GamesContextClass(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public GamesContextClass(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public GamesContextClass(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected GamesContextClass()
        {
        }

       protected GamesContextClass(DbCompiledModel model) : base(model)
        {
        }
    }
}
