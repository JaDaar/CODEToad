using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CODEToad.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeToadModel : DbContext
    {
        // Your context has been configured to use a 'CodeToadModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CODEToad.Data.CodeToadModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CodeToadModel' 
        // connection string in the application configuration file.
        public CodeToadModel()
            : base("name=CodeToadData")
        {
            Database.SetInitializer<CodeToadModel>(new CreateDatabaseIfNotExists<CodeToadModel>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<CodeNotes> CodeNodeList { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class DatabaseConfiguration : DbMigrationsConfiguration<CodeToadModel>
    //{
    //    public DatabaseConfiguration()
    //    {
    //        this.AutomaticMigrationsEnabled = false;
    //    }
    //}

    public class CodeNotes
    {
        [Key]
        public int CodeNoteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Snippet { get; set; }
        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(1)]
        public string StatusCode { get; set; }
    }
}