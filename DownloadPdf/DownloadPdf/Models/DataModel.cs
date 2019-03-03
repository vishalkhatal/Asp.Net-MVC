using System.Data.Entity;

namespace DownloadPdf.Models
{
    public  class DataModel:DbContext
    {
        public DbSet <Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
        }


    }
}
