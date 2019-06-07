using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CyclicGraphDetectorDataAccess
{
    public class CsvDataContext: DbContext
    {
        public CsvDataContext()
            : base("name=CvscontentsDb")
        {
        }
        public virtual DbSet<CsvFile> CsvFileContents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
